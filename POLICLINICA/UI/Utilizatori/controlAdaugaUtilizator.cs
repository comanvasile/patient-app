using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Policlinica.Entities;
using Policlinica.Data.Services;
using POLICLINICA.Mesagerie;

namespace POLICLINICA.UI
{
    public partial class controlAdaugaUtilizator : UserControl
    {
        public controlAdaugaUtilizator()
        {
            InitializeComponent();

            this.IncarcaDate();
            this.dateTimePickerDataAngajare.Value = DateTime.Now;
            this.dropDownDepartament.SelectedValueChanged += new EventHandler(dropDownDepartament_SelectedIndexChanged);

        }
        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                base.OnLoad(e);
                //this.IncarcaDate();
                //this.dateTimePickerDataAngajare.Value = DateTime.Now;
                //this.dropDownDepartament.SelectedValueChanged += new EventHandler(dropDownDepartament_SelectedIndexChanged);
            }
        }

        public String GetFunctie()
        {
            String functie;
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                functie = new UtilizatoriService(dc).GetFunctieById((int)this.dropDownFunctie.SelectedValue);
            }
            return functie;
        }

        private void IncarcaDate()
        {
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                UtilizatoriService us = new UtilizatoriService(dc);
                this.dropDownUnitate.DataSource = us.GetUnitatiMedicale();
                this.dropDownDepartament.DataSource = us.GetDepartamente();
                this.dropDownUnitate.ValueMember = this.dropDownDepartament.ValueMember = "Key";
                this.dropDownUnitate.DisplayMember = this.dropDownDepartament.DisplayMember = "Value";
                this.dropDownFunctie.DataSource = us.GetFunctii((int)this.dropDownDepartament.SelectedValue);
                this.dropDownRol.DataSource = us.GetRoluri();
                this.dropDownRol.ValueMember = this.dropDownFunctie.ValueMember = "Key";
                this.dropDownRol.DisplayMember = dropDownFunctie.DisplayMember = "Value";

                this.textBoxNrContract.Text = us.GetNrContract().ToString();
            }
            
        }

        public Utilizatori GetUtilizator()
        {
            Utilizatori utilizator = new Utilizatori();
            utilizator.Nume = this.textBoxNume.Text;
            utilizator.Prenume = this.textBoxPrenume.Text;
            utilizator.CNP = this.textBoxCNP.Text;
            utilizator.Telefon = this.textBoxTelefon.Text;
            utilizator.Email = this.textBoxEmail.Text;
            utilizator.Adresa = this.textBoxAdresa.Text;
            utilizator.NumarContract = int.Parse(this.textBoxNrContract.Text);
            utilizator.DataAngajare = this.dateTimePickerDataAngajare.Value;
            utilizator.Salar = this.spinEditorSalar.Value;
            utilizator.IBAN = this.textBoxIBAN.Text;
            utilizator.Fk_UnitateMedicalaId = (int)this.dropDownUnitate.SelectedValue;
            utilizator.Fk_FunctieId = (int)this.dropDownFunctie.SelectedValue;
            utilizator.Fk_RolId = (int)this.dropDownRol.SelectedValue;

            return utilizator;
        }

        public void SetUtilizator(Utilizatori utilizator)
        {
            this.textBoxNume.Text = utilizator.Nume;
            this.textBoxPrenume.Text = utilizator.Prenume;
            this.textBoxCNP.Text = utilizator.CNP;
            this.textBoxTelefon.Text = utilizator.Telefon;
            this.textBoxEmail.Text = utilizator.Email;
            this.textBoxAdresa.Text = utilizator.Adresa;
            this.textBoxNrContract.Text = utilizator.NumarContract.ToString();
            this.dateTimePickerDataAngajare.Value = utilizator.DataAngajare;
            this.spinEditorSalar.Value = utilizator.Salar;
            this.textBoxIBAN.Text = utilizator.IBAN;
            this.dropDownUnitate.SelectedValue = utilizator.Fk_UnitateMedicalaId;
            this.dropDownDepartament.SelectedValue = utilizator.FunctiiDepartament.Departament.DepartamentId;
            this.dropDownFunctie.SelectedValue = utilizator.Fk_FunctieId;
            this.dropDownRol.SelectedValue = utilizator.Fk_RolId;

            this.SetReadOnly(true);

        }

        private void SetReadOnly(bool v)
        {
            this.dateTimePickerDataAngajare.ReadOnly = v;
        }

        private void dropDownDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                this.dropDownFunctie.DataSource = new UtilizatoriService(dc).GetFunctii((int)this.dropDownDepartament.SelectedValue);
            }
        }

        public Utilizatori GetUtilizator(Utilizatori utilizator)
        {
            utilizator.Nume = this.textBoxNume.Text;
            utilizator.Prenume = this.textBoxPrenume.Text;
            utilizator.CNP = this.textBoxCNP.Text;
            utilizator.Telefon = this.textBoxTelefon.Text;
            utilizator.Email = this.textBoxEmail.Text;
            utilizator.Adresa = this.textBoxAdresa.Text;
            utilizator.NumarContract = int.Parse(this.textBoxNrContract.Text);
            utilizator.DataAngajare = this.dateTimePickerDataAngajare.Value;
            utilizator.Salar = this.spinEditorSalar.Value;
            utilizator.IBAN = this.textBoxIBAN.Text;
            utilizator.Fk_UnitateMedicalaId = (int)this.dropDownUnitate.SelectedValue;
            utilizator.Fk_FunctieId = (int)this.dropDownFunctie.SelectedValue;
            utilizator.Fk_RolId = (int)this.dropDownRol.SelectedValue;

            return utilizator;
        }

        private void textBoxCNP_Validated(object sender, EventArgs e)
        {
            if(this.textBoxCNP.TextLength != 13)
            {
                Mesaje.Afiseaza(TextMesaje.CNP_NEVALID, TipuriMesaje.Eroare);
            }
        }


        
    }
}

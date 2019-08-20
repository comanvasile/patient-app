using Policlinica.Data.Enums;
using Policlinica.Data.Services;
using Policlinica.Entities;
using Policlinica.Resurse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace POLICLINICA.UI
{
    public partial class FereastraVizualizareDatePersonale : Telerik.WinControls.UI.RadForm
    {
        Utilizatori utilizator;
        Medic medic;
        AsistentMedical asistent;
        public FereastraVizualizareDatePersonale()
        {
            InitializeComponent();
            this.CitireUtilizator();
            this.IncarcaImagini();
        }

        private void IncarcaImagini()
        {
            this.buttonIesire.Image = PoliclinicaResurse.Back_32;
        }
        private void CitireUtilizator()
        {
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                var service = new UtilizatoriService(dc);

                utilizator = service.GetUtilizatorById(Program.UtilizatorCurent.UtilizatorId);
                medic = utilizator.Medic;
                asistent = utilizator.AsistentMedical;

                this.textBoxUnitate.Text = utilizator.UnitateMedicala.Denumire;
                this.textBoxDepartament.Text = utilizator.FunctiiDepartament.Departament.Nume;
                this.textBoxFunctie.Text = utilizator.FunctiiDepartament.Functie;
                this.textBoxRol.Text = utilizator.Roluri.Nume;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                base.OnLoad(e);
                this.IncarcaDate();
            }
        }

        private void IncarcaDate()
        {
            this.ConfigurareTabOrar();
            this.ConfigurareTabDatePersonale();
            
        }

        private void ConfigurareTabDatePersonale()
        {
            this.IncarcaUtilizator();
            this.IncarcaMedic();
            this.IncarcaAsistentMedical();
        }

        private void IncarcaAsistentMedical()
        {
            if (utilizator.AsistentMedical == null)
            {
                this.groupBoxAsistentMedical.Dispose();
            }
            else
            {
                this.textBoxGradAsistent.Text = ((GradAsistentMedical)asistent.Grad).ToString();
                this.textBoxTip.Text = ((TipAsistentMedical)asistent.Tip).ToString();
            }
        }

        private void IncarcaMedic()
        {
            if(utilizator.Medic == null)
            {
                this.groupBoxMedic.Dispose();
            }
            else
            {
                this.textBoxGradMedic.Text = ((GradMedic)medic.Grad).ToString();
                this.textBoxParafa.Text = medic.CodulDeParafa;
                this.textBoxTitlu.Text = ((TitluStiintific)medic.TitlulStiintific).ToString();
                this.textBoxPostDidactic.Text = ((PostDidactic)medic.PostulDidactic).ToString();
                this.spinEditorProcentServicii.Value = (decimal)medic.ProcentServicii;
            }
        }

        private void IncarcaUtilizator()
        {
            this.textBoxNume.Text = utilizator.Nume;
            this.textBoxPrenume.Text = utilizator.Prenume;
            this.textBoxCNP.Text = utilizator.CNP;
            this.textBoxTelefon.Text = utilizator.Telefon;
            this.textBoxEmail.Text = utilizator.Email;
            this.textBoxAdresa.Text = utilizator.Adresa;
            this.textBoxNrContract.Text = utilizator.NumarContract.ToString();
            this.textBoxDataAngajare.Text = utilizator.DataAngajare.Date.ToString("dd/MM/yyyy");
            this.spinEditorSalar.Value = utilizator.Salar;
            this.textBoxIBAN.Text = utilizator.IBAN;
        }

        private void ConfigurareTabOrar()
        {
            this.controlAdaugaOrarUtilizatori1.IncarcaZile(utilizator.UtilizatorId);
            this.controlAdaugaOrarUtilizatori1.SetReadOnly();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

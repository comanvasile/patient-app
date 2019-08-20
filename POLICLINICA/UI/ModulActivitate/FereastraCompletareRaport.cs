using Policlinica.Data;
using Policlinica.Data.Enums;
using Policlinica.Data.Services;
using Policlinica.Entities;
using Policlinica.Resurse;
using POLICLINICA.Mesagerie;
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
    public partial class FereastraCompletareRaport : Telerik.WinControls.UI.RadForm
    {
        private int serviciuMedicalId = 0;

        public FereastraCompletareRaport(int serviciuMedicalId)
        {
            InitializeComponent();
            this.serviciuMedicalId = serviciuMedicalId;
            this.IncarcaRaport();
            this.IncarcaImagini();
        }

        private void IncarcaImagini()
        {
            this.buttonRenunta.Image = PoliclinicaResurse.Back_32;
            this.buttonSalveaza.Image = PoliclinicaResurse.Save_32;
        }

        private void IncarcaRaport()
        {
            this.dateTimePicker.Value = DateTime.Now;

            this.dropDownStatus.DataSource = Unelte.GetEnumValues(typeof(StatusConsultatie));
            this.dropDownStatus.ValueMember = "Key";
            this.dropDownStatus.DisplayMember = "Value";

            this.textBoxMedic.Text = Program.UtilizatorCurent.Nume + " " + Program.UtilizatorCurent.Prenume;
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                this.textBoxPacient.Text = new ActivitateService(dc).GetPacientString(serviciuMedicalId);
            }
            if(Program.UtilizatorCurent.Fk_RolId == (int)RoluriAcces.Asistent)
            {
                this.labelMedic.Text = "Asistent:";
                this.textBoxMedic.ReadOnly = true;
            }
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            if(this.Salveaza())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Salveaza()
        {
            try
            {
                var raport = new RaportMedical();

                raport.Fk_ServiciuMedicalId = serviciuMedicalId;
                raport.NumePrenumeMedic = this.textBoxMedic.Text;
                raport.NumePrenumePacient = this.textBoxPacient.Text;
                raport.DataConsultatie = this.dateTimePicker.Value;
                raport.Istoric = this.textBoxIstoric.Text;
                raport.Simptome = this.textBoxSimptome.Text;
                raport.Investigații = this.textBoxInvestigatii.Text;
                raport.Diagnostic = this.textBoxDisgnostic.Text;
                raport.Recomandări = this.textBoxRecomandari.Text;
                raport.Status = (int)this.dropDownStatus.SelectedValue;

                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    new ActivitateService(dc).AddRaportMedical(raport);
                }

                return true;
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_SALVARE +"\n" + ex.Message, TipuriMesaje.Eroare);
                return false;
            }
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

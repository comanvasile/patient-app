using Policlinica.Data.Enums;
using Policlinica.Data.Services;
using Policlinica.Data.StoredProcedures;
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
    public partial class FereastraIstoricPacient : Telerik.WinControls.UI.RadForm
    {
        private int pacientId = 0;

        public FereastraIstoricPacient(int pacientId)
        {
            InitializeComponent();
            this.pacientId = pacientId;
            this.radRibbonBar1.Text += this.GetStringPacient();
            this.IncarcaDate();
            this.buttonIesire.Image = PoliclinicaResurse.Back_32;
        }

        private void IncarcaDate()
        {
            try
            {
                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    this.radGridView1.BeginUpdate();
                    this.radGridView1.DataSource = new ProceduriStocateService(dc).LoadIstoricPacient(pacientId);
                    this.radGridView1.Columns["StatusConsultatie"].DataType = typeof(StatusConsultatie);
                    this.radGridView1.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_INCARCARE_DATE + "\n" + ex.Message, TipuriMesaje.Eroare);
            }
        }

        private string GetStringPacient()
        {
            string nume;
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                var pacient = new ActivitateService(dc).GetPacientById(pacientId);
                nume = pacient.Nume + " " + pacient.Prenume;
            }
            return nume;
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using Policlinica.Data.Enums;
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
    public partial class FereastraActivitateMedic : Telerik.WinControls.UI.RadForm
    {        
        public FereastraActivitateMedic()
        {
            InitializeComponent();
            this.IncarcaImagini();
            this.radRibbonBar1.Text += " | " + Program.UtilizatorCurent.Nume + " " + Program.UtilizatorCurent.Prenume;
            this.IncarcaPacienti();
        }

        private void IncarcaImagini()
        {
            this.buttonIesire.Image = PoliclinicaResurse.Back_32;
            this.buttonRaport.Image = PoliclinicaResurse.Completare_raport_32;
            this.buttonIstoricPacient.Image = PoliclinicaResurse.Istoric_pacient_32;
        }

        private void IncarcaPacienti()
        {
            if (Program.UtilizatorCurent.Fk_RolId == (int)RoluriAcces.Medic)
                IncarcaPacientiMedic();
            else
            {
                IncarcaPacientiAsistent();
                this.checkAzi.ReadOnly = true;
            }
        }

        private void IncarcaPacientiAsistent()
        {
            try
            {
                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    this.gridPacienti.BeginUpdate();
                    this.gridPacienti.DataSource = null;
                    this.gridPacienti.DataSource = new ProceduriStocateService(dc).LoadPacientiAsistent(this.checkAzi.Checked, Program.UtilizatorCurent.Fk_UnitateMedicalaId);
                    this.gridPacienti.Columns["NumeMedic"].IsVisible = true;
                    this.gridPacienti.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_INCARCARE_DATE + "\n" + ex.Message, TipuriMesaje.Eroare);
            }
        }

        private void IncarcaPacientiMedic()
        {
            try
            {
                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    this.gridPacienti.BeginUpdate();
                    this.gridPacienti.DataSource = null;
                    this.gridPacienti.DataSource = new ProceduriStocateService(dc).LoadPacientiMedic(this.checkAzi.Checked, Program.UtilizatorCurent.Fk_UnitateMedicalaId, Program.UtilizatorCurent.UtilizatorId);
                    this.gridPacienti.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_INCARCARE_DATE + "\n" + ex.Message, TipuriMesaje.Eroare);
            }
        }

        private void checkAzi_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.IncarcaPacienti();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public LoadPacientiMedic_Result PacientSelectat
        {
            get
            {
                return this.gridPacienti.CurrentRow.DataBoundItem as LoadPacientiMedic_Result;
            }
        }

        private void buttonRaport_Click(object sender, EventArgs e)
        {
            if(this.gridPacienti.CurrentRow != null && this.gridPacienti.CurrentRow.DataBoundItem != null)
            {
                if ((bool)gridPacienti.CurrentRow.Cells["Realizata"].Value == true)
                    return;
                if(new FereastraCompletareRaport((int)gridPacienti.CurrentRow.Cells["ServiciuMedicalId"].Value).ShowDialog() == DialogResult.OK)
                {
                    this.IncarcaPacienti();
                }
            }
        }

        private void buttonIstoricPacient_Click(object sender, EventArgs e)
        {
            if(this.gridPacienti.CurrentRow != null && this.gridPacienti.CurrentRow.DataBoundItem != null)
                new FereastraIstoricPacient((int)gridPacienti.CurrentRow.Cells["PacientId"].Value).ShowDialog();
        }
    }
}

using Policlinica.Data.Models;
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
    public partial class FereastraAdaugaSpecialitatiMedic : Telerik.WinControls.UI.RadForm
    {
        public FereastraAdaugaSpecialitatiMedic()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.IncarcaMedici();
            this.IncarcaSpecialitati();
            this.MarcheazaSpecialitati();
            this.buttonIesire.Image = PoliclinicaResurse.Back_32;
        }

        private void MarcheazaSpecialitati()
        {
            if (MedicCurent == null)
                return;
            IList<Specialitati> specialitatiMedic;
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                specialitatiMedic = new UtilizatoriService(dc).GetSpecialitati(MedicCurent.UtilizatorId);
            }
            bool ok = true;
            foreach (var row in gridSpecialitati.Rows)
            {
                ok = true;
                foreach (var s in specialitatiMedic)
                {
                    if (row.Cells["Nume"].Value.ToString() == s.Nume)
                    {
                        row.Cells["Activa"].Value = true;
                        ok = false;
                    }
                }
                if (ok == true)
                    row.Cells["Activa"].Value = false;
            }
        }

        private void IncarcaSpecialitati()
        {
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                gridSpecialitati.BeginUpdate();
                gridSpecialitati.DataSource = null;
                gridSpecialitati.DataSource = new UtilizatoriService(dc).GetSpecialitati();
                gridSpecialitati.EndUpdate();
            }
        }

        private void IncarcaMedici()
        {
            IList<MedicModel> listaMedici; 
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                //gridMedici.BeginUpdate();
                listaMedici = new UtilizatoriService(dc).GetMedici(Program.UtilizatorCurent.Fk_UnitateMedicalaId);
                //gridMedici.CurrentRow = gridMedici.Rows[1];
                //gridMedici.EndUpdate();
            }
            try
            {

            gridMedici.BeginUpdate();
            gridMedici.DataSource = null;
            gridMedici.DataSource = listaMedici;
                //gridMedici.CurrentRow = gridMedici.Rows[0];
                gridMedici.EndUpdate();


            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(ex.Message, TipuriMesaje.Eroare);
                throw;
            }
        }

        public MedicModel MedicCurent
        {
            get
            {
                return this.gridMedici.CurrentRow.DataBoundItem as MedicModel;
            }
        }
        
        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridMedici_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (gridMedici.CurrentRow.DataBoundItem != null && gridSpecialitati.DataSource != null)
                this.MarcheazaSpecialitati();
        }

        private void gridMedici_CurrentRowChanging(object sender, Telerik.WinControls.UI.CurrentRowChangingEventArgs e)
        {
            if (gridMedici.CurrentRow != null && gridMedici.CurrentRow.DataBoundItem != null && gridSpecialitati.DataSource != null)
                this.SalveazaSpecialitati();
        }

        private void SalveazaSpecialitati()
        {
            try
            {
                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    var proceduri = new ProceduriStocateService(dc);

                    proceduri.DeleteFromMedicSpecialitati(this.MedicCurent.UtilizatorId);

                    foreach (var row in gridSpecialitati.Rows)
                    {
                        if ((bool)row.Cells["Activa"].Value == true)
                        {
                            proceduri.InsertMedicSpecialitati(this.MedicCurent.UtilizatorId, (row.DataBoundItem as Specialitati).SpecialitateId);
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_SALVARE + "\n" + ex.Message, TipuriMesaje.Eroare);
            }
        }
    }
}

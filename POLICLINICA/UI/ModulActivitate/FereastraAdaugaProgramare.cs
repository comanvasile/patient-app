using Policlinica.Data.Models;
using Policlinica.Data.Services;
using Policlinica.Data.StoredProcedures;
using Policlinica.Entities;
using POLICLINICA.Mesagerie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace POLICLINICA.UI
{
    public partial class FereastraAdaugaProgramare : Telerik.WinControls.UI.RadForm
    {
        public FereastraAdaugaProgramare()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.IncarcaSpecialitati();
            this.IncarcaPacienti();
        }

        private void IncarcaPacienti()
        {
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                ActivitateService service = new ActivitateService(dc);

                this.dropDownPacienti.BeginUpdate();
                this.dropDownPacienti.DataSource = null;
                this.dropDownPacienti.DataSource = service.GetPacienti();
                this.dropDownPacienti.ValueMember = this.dropDownPacienti.ValueMember = "Key";
                this.dropDownPacienti.DisplayMember = this.dropDownPacienti.DisplayMember = "Value";
                this.dropDownPacienti.EndUpdate();
            }
        }

        private void IncarcaSpecialitati()
        {
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                gridSpecialitati.BeginUpdate();
                gridSpecialitati.DataSource = null;
                gridSpecialitati.DataSource = new ProceduriStocateService(dc).LoadSpecialitatiUnitate(Program.UtilizatorCurent.Fk_UnitateMedicalaId);
                this.MarcheazaSpecialitati(false);
                gridSpecialitati.EndUpdate();
            }
        }

        private void MarcheazaSpecialitati(bool v)
        {
            foreach (var row in gridSpecialitati.Rows)
            {
                row.Cells["Activa"].Value = v;
            }
        }

        private void radWizard1_Next(object sender, Telerik.WinControls.UI.WizardCancelEventArgs e)
        {
            if (this.GetSpecialitatiSelectate().Count == 0 || dropDownPacienti.SelectedItem == null)
            {
                Mesaje.Afiseaza(TextMesaje.SPECIALITATI_NESELECTATE, TipuriMesaje.Atentionare);
                e.Cancel = true;
            }
            else
            {
                this.IncarcaGridProgramari();
                this.radWizard1.Pages[1].Title = "Selectare medic si data programare | " + this.dropDownPacienti.SelectedItem.DisplayValue.ToString();
            }
        }

        private void IncarcaGridProgramari()
        {
            var specialitati = GetSpecialitatiSelectate();
            IList<ProgramareServiciiModel> datasource = new List<ProgramareServiciiModel>();
            GridViewComboBoxColumn medicColumn = gridProgramare.Columns["Medic"] as GridViewComboBoxColumn;
            medicColumn.ValueMember = "Key";
            medicColumn.DisplayMember = "Value";
            foreach (var s in specialitati)
            {
                datasource.Add(new ProgramareServiciiModel() { SpecialitateId = s.SpecialitateId, Nume = s.Nume, DataProgramare = DateTime.Now });
            }

            gridProgramare.BeginUpdate();
            gridProgramare.DataSource = datasource;
            gridProgramare.EndUpdate();
        }

        private IList<LoadSpecialitatiUnitate_Result> GetSpecialitatiSelectate()
        {
            IList<LoadSpecialitatiUnitate_Result> specialitati = new List<LoadSpecialitatiUnitate_Result>();
            if (this.gridSpecialitati.DataSource != null)
            {
                foreach (var row in gridSpecialitati.Rows)
                {
                    if ((bool)row.Cells["Activa"].Value == true)
                        specialitati.Add(row.DataBoundItem as LoadSpecialitatiUnitate_Result);
                }
            }
            return specialitati;
        }

        private void gridProgramare_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.HeaderText == "Medic")
            {
                if (this.gridProgramare.CurrentRow.Cells["SpecialitateId"].Value != DBNull.Value
                    //&& this.gridProgramare.CurrentRow.Cells["Medic"].Value == null
                    )
                {
                    RadDropDownListEditor editor = (RadDropDownListEditor)this.gridProgramare.ActiveEditor;
                    RadDropDownListEditorElement editorElement = (RadDropDownListEditorElement)editor.EditorElement;
                    using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                    {
                        editorElement.DataSource = null;
                        editorElement.DataSource = new ProceduriStocateService(dc).GetMedici((int)this.gridProgramare.CurrentRow.Cells["SpecialitateId"].Value, Program.UtilizatorCurent.Fk_UnitateMedicalaId);
                    }

                    //editorElement.SelectedValue = null;
                    //editorElement.SelectedValue = this.gridProgramare.CurrentCell.Value;
                }
            }
        }

        private void menuAdaugaPacient_Click(object sender, EventArgs e)
        {
            if(new FereastraAdaugaPacienti().ShowDialog() == DialogResult.OK)
            {
                this.IncarcaPacienti();
            }
        }

        private void radWizard1_Cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radWizard1_Finish(object sender, EventArgs e)
        {
            if(this.Salveaza() == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Salveaza()
        {
            try
            {
                var listaProgramari = this.gridProgramare.DataSource as List<ProgramareServiciiModel>;
                foreach (var p in listaProgramari)
                {
                    using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                    {
                        new ProceduriStocateService(dc).InserProgramariServicii((int)this.dropDownPacienti.SelectedValue, Program.UtilizatorCurent.UtilizatorId, p.DataProgramare, false, p.Competenta, p.Pret, p.Durata, Program.UtilizatorCurent.Fk_UnitateMedicalaId, p.Medic, p.SpecialitateId);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_SALVARE + "\n" + ex.Message, TipuriMesaje.Eroare);
                return false;
            }
        }
    }
}

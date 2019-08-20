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
using Policlinica.Data.Models;
using Policlinica.Data.Enums;
using Policlinica.Data.Services;
using POLICLINICA.Mesagerie;

namespace POLICLINICA.UI
{
    public partial class controlAdaugaOrarUtilizatori : UserControl
    {
        public controlAdaugaOrarUtilizatori()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                base.OnLoad(e);
            }
        }

        public void IncarcaZile()
        {
            List<OrarUtilizatorModel> orar = new List<OrarUtilizatorModel>() { new OrarUtilizatorModel() { Zi = ZileOrar.Luni , IncepereProgram = new TimeSpan(08,00,00), SfarsitProgram = new TimeSpan(16,00,00)},
                                                                               new OrarUtilizatorModel() { Zi = ZileOrar.Marti , IncepereProgram = new TimeSpan(08,00,00), SfarsitProgram = new TimeSpan(16,00,00)},
                                                                               new OrarUtilizatorModel() { Zi = ZileOrar.Miercuri , IncepereProgram = new TimeSpan(08,00,00), SfarsitProgram = new TimeSpan(16,00,00)},
                                                                               new OrarUtilizatorModel() { Zi = ZileOrar.Joi , IncepereProgram = new TimeSpan(08,00,00), SfarsitProgram = new TimeSpan(16,00,00)},
                                                                               new OrarUtilizatorModel() { Zi = ZileOrar.Vineri , IncepereProgram = new TimeSpan(08,00,00), SfarsitProgram = new TimeSpan(16,00,00)},
                                                                               new OrarUtilizatorModel() { Zi = ZileOrar.Sambata , IncepereProgram = new TimeSpan(08,00,00), SfarsitProgram = new TimeSpan(16,00,00)},
                                                                               new OrarUtilizatorModel() { Zi = ZileOrar.Duminica , IncepereProgram = new TimeSpan(08,00,00), SfarsitProgram = new TimeSpan(16,00,00)}};
            gridViewOrar.BeginUpdate();
            gridViewOrar.DataSource = orar;
            gridViewOrar.EndUpdate();
        }

        public void SetReadOnly()
        {
            this.radMenu1.Dispose();
            this.gridViewOrar.AllowAddNewRow = false;
            this.gridViewOrar.ReadOnly = true;
            this.gridViewOrar.EnableGrouping = true;
            this.gridViewOrar.EnableFiltering = true;
        }

        public void IncarcaZile(int utilizatorId)
        {
            IList<OrarUtilizatorModel> orar;
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                orar = new UtilizatoriService(dc).GetOrarUtilizator(utilizatorId);
            }

            gridViewOrar.BeginUpdate();
            gridViewOrar.DataSource = null;
            gridViewOrar.DataSource = orar;
            gridViewOrar.EndUpdate();
        }

        public ICollection<OrarUtilizatori> GetOrarUtilizator()
        {
            var orar = this.gridViewOrar.DataSource as List<OrarUtilizatorModel>;

            return (from o in orar
                    select new OrarUtilizatori
                    {
                        OrarId = o.OrarId,
                        Zi = (int)o.Zi,
                        IncepereProgram = o.IncepereProgram,
                        SfarsitProgram = o.SfarsitProgram,
                        DataZiSpeciala = o.DataZiSpeciala,
                        Fk_UtilizatorId = o.Fk_UtilizatorId
                    }).ToList();
        }

        private void MasterTemplate_EditorRequired(object sender, Telerik.WinControls.UI.EditorRequiredEventArgs e)
        {
            if (gridViewOrar.CurrentColumn.Name == "IncepereProgram" || gridViewOrar.CurrentColumn.Name == "SfarsitProgram")
            {
                e.EditorType = typeof(TimeEditor);
            }
        }

        public OrarUtilizatorModel GetZiSelectata
        {
            get
            {
                return this.gridViewOrar.CurrentRow.DataBoundItem as OrarUtilizatorModel;
            }
        }

        private void menuButtonCO_Click(object sender, EventArgs e)
        {
            SeteazaZi(ZileOrar.CO);
        }

        private void menuButtonCM_Click(object sender, EventArgs e)
        {
            this.SeteazaZi(ZileOrar.CM);
        }

        private void menuButtonNemotivat_Click(object sender, EventArgs e)
        {
            SeteazaZi(ZileOrar.Nemotivat);
        }

        private void SeteazaZi(ZileOrar zi)
        {
            if (this.GetZiSelectata == null)
                return;
            else
            {
                if (this.GetZiSelectata.Zi >= ZileOrar.Luni && this.GetZiSelectata.Zi <= ZileOrar.Duminica)
                    return;
                if (this.GetZiSelectata.DataZiSpeciala == null)
                {
                    Mesaje.Afiseaza(TextMesaje.SELECTARE_DATA, TipuriMesaje.Informare);
                    return;
                }
                else
                {
                    this.GetZiSelectata.Zi = zi;

                    if (zi != ZileOrar.AltProgram)
                        this.SeteazaOra(new TimeSpan(00, 00, 00));
                }
            }
        }

        private void SeteazaOra(TimeSpan ora)
        {
            this.GetZiSelectata.IncepereProgram = this.GetZiSelectata.SfarsitProgram = ora;
        }

        private void menuButtonAltProgram_Click(object sender, EventArgs e)
        {
            this.SeteazaZi(ZileOrar.AltProgram);
        }

        private void MasterTemplate_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Column == null || e.Column.Name != "DataZiSpeciala")
                return;
            if (this.GetZiSelectata == null)
                return;
            else
            {
                if (this.GetZiSelectata.Zi >= ZileOrar.Luni && this.GetZiSelectata.Zi <= ZileOrar.Duminica)
                {
                    Mesaje.Afiseaza(TextMesaje.ZI_SAPTAMANA, TipuriMesaje.Informare);
                    this.GetZiSelectata.DataZiSpeciala = null;
                    return;
                }
            }
        }

        private void MasterTemplate_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (e.Rows == null || this.GetZiSelectata == null)
                return;
            if (this.GetZiSelectata.Zi >= ZileOrar.Luni && this.GetZiSelectata.Zi <= ZileOrar.Duminica)
            {
                Mesaje.Afiseaza(TextMesaje.DELETE_ZI_SAPTAMANA, TipuriMesaje.Informare);
                e.Cancel = true;
                return;
            }
        }
    }
}

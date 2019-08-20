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
using Policlinica.Data.StoredProcedures;
using POLICLINICA.Mesagerie;
using Policlinica.Data.Models;

namespace POLICLINICA.UI
{
    public partial class loadUtilizatoriControl : UserControl
    {
        public loadUtilizatoriControl()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                base.OnLoad(e);
                this.LoadData();
            }
        }

        private void LoadData()
        {
            try
            {

                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    gridViewUtilizatori.BeginUpdate();
                    gridViewUtilizatori.DataSource = null;
                    gridViewUtilizatori.DataSource = new ProceduriStocateService(dc).LoadUtilizatori(Program.UtilizatorCurent.Fk_UnitateMedicalaId);
                    gridViewUtilizatori.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_INCARCARE_DATE + "\n" + ex.Message, TipuriMesaje.Eroare);
            }
        }

        public void IncarcaUtilizatori()
        {
            this.LoadData();
        }

        public LoadUtilizatoriModel GetUtilizatorSelectat
        {
            get
            {
                return this.gridViewUtilizatori.CurrentRow.DataBoundItem as LoadUtilizatoriModel;
            }
        }
    }
}

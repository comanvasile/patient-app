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
    public partial class FereastraVizualizareSalariiMedic : Telerik.WinControls.UI.RadForm
    {
        public FereastraVizualizareSalariiMedic()
        {
            InitializeComponent();
            this.IncarcaDropDownList();
            this.IncarcaDate();
            this.IncarcaImagini();
        }

        private void IncarcaImagini()
        {
            this.buttonIesire.Image = PoliclinicaResurse.Back_32;
            this.buttonReincarcaDate.Image = PoliclinicaResurse.Reload_32;
        }

        private void IncarcaDate()
        {
            try
            {
                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    ProceduriStocateService service = new ProceduriStocateService(dc);

                    this.gridSalarii.BeginUpdate();
                    this.gridSalarii.DataSource = null;
                    this.gridSalarii.DataSource = service.GetSalariiMedic((int)this.dropDownAn.SelectedValue,(int)this.dropDownLuna.SelectedValue,Program.UtilizatorCurent.UtilizatorId);
                    this.gridSalarii.EndUpdate();
                }

            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_INCARCARE_DATE + "\n" + ex.Message, TipuriMesaje.Eroare);
                this.Close();
            }
        }

        private void IncarcaDropDownList()
        {
            try
            {
                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    UtilizatoriService service = new UtilizatoriService(dc);

                    var primaAngajare = service.GetUtilizatorById(Program.UtilizatorCurent.UtilizatorId).DataAngajare;

                    this.dropDownAn.DataSource = this.ListaAn(primaAngajare);
                    this.dropDownLuna.DataSource = this.ListaLuna(primaAngajare);
                }
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_INCARCARE_DATE + "\n" + ex.Message, TipuriMesaje.Eroare);
            }
        }

        private IList<int> ListaLuna(DateTime primaAngajare)
        {
            var list = new List<int>();
            var ultimaData = DateTime.Now;
            if (primaAngajare.Year < ultimaData.Year)
                list.AddRange(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            else
                for (int i = 1; i <= ultimaData.Month; i++)
                {
                    list.Add(i);
                }
            return list;
        }

        private IList<int> ListaAn(DateTime primaAngajare)
        {
            var list = new List<int>();
            var primulAn = primaAngajare.Year;
            var anulCurent = DateTime.Now.Year;
            for (int i = primulAn; i <= anulCurent; i++)
            {
                list.Add(i);
            }
            return list;
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReincarcaDate_Click(object sender, EventArgs e)
        {

        }
    }
}

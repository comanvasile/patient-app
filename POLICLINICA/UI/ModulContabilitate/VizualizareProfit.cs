using Policlinica.Data.Enums;
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
using Telerik.WinControls.UI;

namespace POLICLINICA.UI
{
    public partial class VizualizareProfit : Telerik.WinControls.UI.RadForm
    {
        public int SumeContabile { get; private set; }

        public VizualizareProfit()
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
                IList<Venituri_Result> venituri;
                IList<Cheltuieli_Result> cheltuieli;
               
                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    ProceduriStocateService service = new ProceduriStocateService(dc);
                    venituri = service.GetVenituri((int)this.dropDownAn.SelectedValue, (int)this.dropDownLuna.SelectedValue, (int)this.dropDownUnitate.SelectedValue);
                    cheltuieli = service.GetCheltuieli((int)this.dropDownAn.SelectedValue, (int)this.dropDownLuna.SelectedValue, (int)this.dropDownUnitate.SelectedValue);
                }

                this.gridVenituri.BeginUpdate();
                this.gridVenituri.DataSource = null;
                this.gridVenituri.DataSource = venituri;
                //this.gridVenituri.Columns["Grad"].DataType = typeof(GradMedic);
                //this.gridVenituri.Columns["PostulDidactic"].DataType = typeof(PostDidactic);
                this.gridVenituri.EndUpdate();

                this.gridCheltuieli.BeginUpdate();
                this.gridCheltuieli.DataSource = null;
                this.gridCheltuieli.DataSource = cheltuieli;
                this.gridCheltuieli.EndUpdate();

                this.gridRaport.BeginUpdate();
                this.gridRaport.DataSource = null;
                this.gridRaport.DataSource = this.GetSume(venituri, cheltuieli);
                this.gridRaport.EndUpdate();
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_INCARCARE_DATE + "\n" + ex.Message, TipuriMesaje.Eroare);
                this.Close();
            }
        }

        private IList<SumeContabileModel> GetSume(IList<Venituri_Result> venituri, IList<Cheltuieli_Result> cheltuieli)
        {
            IList<SumeContabileModel> sume = new List<SumeContabileModel>();
            decimal sumaVenit = 0;
            decimal sumaCheltuieli = 0;
            foreach (var venit in venituri)
            {
                sumaVenit += (decimal)venit.Pret;
            }

            foreach (var plati in cheltuieli)
            {
                sumaCheltuieli += (decimal)plati.Salar;
                if(plati.ProcentServicii != null && plati.ProcentServicii != 0)
                    sumaCheltuieli += (decimal)plati.ProcentServicii;
            }

            sume.Add(new SumeContabileModel { TipValori = ValoriContabile.Incasari, Valoare = sumaVenit });
            sume.Add(new SumeContabileModel { TipValori = ValoriContabile.Cheltuieli, Valoare = sumaCheltuieli });
            sume.Add(new SumeContabileModel { TipValori = ValoriContabile.Profit, Valoare = sumaVenit - sumaCheltuieli });

            return sume;
        }

        private void IncarcaDropDownList()
        {
            try
            {
                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    UtilizatoriService service = new UtilizatoriService(dc);

                    this.dropDownUnitate.DataSource = service.GetUnitatiMedicale();
                    this.dropDownUnitate.ValueMember = "Key";
                    this.dropDownUnitate.DisplayMember = "Value";

                    var primaAngajare = service.GetPrimaAngajare((int)this.dropDownUnitate.SelectedValue);

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

        private void buttonReincarcaDate_Click(object sender, EventArgs e)
        {
            this.IncarcaDate();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

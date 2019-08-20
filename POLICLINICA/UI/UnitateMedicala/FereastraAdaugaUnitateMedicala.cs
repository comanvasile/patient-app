using Policlinica.Data;
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
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace POLICLINICA.UI
{
    public partial class FereastraAdaugaUnitateMedicala : Telerik.WinControls.UI.RadForm
    {
        public FereastraAdaugaUnitateMedicala()
        {
            InitializeComponent();
            //TelerikMetroTheme theme = new TelerikMetroTheme();
            ThemeResolutionService.ApplicationThemeName = "Office2010Silver";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.IncarcaJudete();
            this.IncarcaZileGrid();
            this.IncarcaImagini();
        }

        private void IncarcaImagini()
        {
            this.buttonIesire.Image = PoliclinicaResurse.Back_32;
            this.buttonSalveaza.Image = PoliclinicaResurse.Save_32;
        }

        private void IncarcaZileGrid()
        {
            List<OrarUnitateMedicala> orar = new List<OrarUnitateMedicala>() { new OrarUnitateMedicala() { Zi = 1 , OraDeschidere = new TimeSpan(08,00,00), OraInchidere = new TimeSpan(20,00,00)},
                                                                               new OrarUnitateMedicala() { Zi = 2 , OraDeschidere = new TimeSpan(08,00,00), OraInchidere = new TimeSpan(20,00,00)},
                                                                               new OrarUnitateMedicala() { Zi = 3 , OraDeschidere = new TimeSpan(08,00,00), OraInchidere = new TimeSpan(20,00,00)},
                                                                               new OrarUnitateMedicala() { Zi = 4 , OraDeschidere = new TimeSpan(08,00,00), OraInchidere = new TimeSpan(20,00,00)},
                                                                               new OrarUnitateMedicala() { Zi = 5 , OraDeschidere = new TimeSpan(08,00,00), OraInchidere = new TimeSpan(20,00,00)},
                                                                               new OrarUnitateMedicala() { Zi = 6 , OraDeschidere = new TimeSpan(08,00,00), OraInchidere = new TimeSpan(20,00,00)},
                                                                               new OrarUnitateMedicala() { Zi = 7 , OraDeschidere = new TimeSpan(08,00,00), OraInchidere = new TimeSpan(20,00,00)}};
            gridViewOrar.BeginUpdate();
            gridViewOrar.DataSource = orar;
            gridViewOrar.EndUpdate();
        }

        private void IncarcaJudete()
        {
            this.dropDownJudet.DataSource = Unelte.GetJudete();
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            UnitateMedicala um = new UnitateMedicala();
            Adresa adresa = new Adresa();
            List<OrarUnitateMedicala> orar = new List<OrarUnitateMedicala>();

            um.Denumire = textBoxDenumire.Text;
            um.DescriereSrvicii = textBoxControlDescriere.Text;

            adresa.Adresa1 = this.textBoxAdresa.Text;
            adresa.Judet = this.dropDownJudet.SelectedValue.ToString();
            adresa.Localitate = this.textBoxLocalitate.Text;
            adresa.Numar = textBoxNumar.Text;

            orar = this.gridViewOrar.DataSource as List<OrarUnitateMedicala>;
            try
            {
                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    new UtilizatoriService(dc).AddUnitateMedicala(um, adresa, orar);
                }
                Mesaje.Afiseaza(TextMesaje.SALVARE, TipuriMesaje.Informare);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(ex.Message, TipuriMesaje.Eroare);
            }
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridViewOrar_EditorRequired(object sender, Telerik.WinControls.UI.EditorRequiredEventArgs e)
        {
            if (gridViewOrar.CurrentColumn.Name == "OraDeschidere" || gridViewOrar.CurrentColumn.Name == "OraInchidere")
            {
                e.EditorType = typeof(TimeEditor);
            }
        }
    }
}

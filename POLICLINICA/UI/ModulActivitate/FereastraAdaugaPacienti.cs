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
    public partial class FereastraAdaugaPacienti : Telerik.WinControls.UI.RadForm
    {
        private int pacientId = 0;

        public FereastraAdaugaPacienti()
        {
            InitializeComponent();
        }

        public FereastraAdaugaPacienti(int pacientId)
        {
            InitializeComponent();
            this.pacientId = pacientId;
            this.IncarcaDate();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.IncarcaImagini();
        }

        private void IncarcaImagini()
        {
            this.buttonRenunta.Image = PoliclinicaResurse.Back_32;
            this.buttonSalvare.Image = PoliclinicaResurse.Save_32;
        }

        private void IncarcaDate()
        {
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                var pacient = new ActivitateService(dc).GetPacientById(pacientId);

                textBoxNume.Text = pacient.Nume;
                textBoxPrenume.Text = pacient.Prenume;
                textBoxCNP.Text = pacient.CNP;
                textBoxCardSanatate.Text = pacient.CardSanatate;
                textBoxOcupatie.Text = pacient.Ocupatie;
            }
        }

        private void textBoxCNP_Validated(object sender, EventArgs e)
        {
            if (this.textBoxCNP.TextLength != 13)
            {
                Mesaje.Afiseaza(TextMesaje.CNP_NEVALID, TipuriMesaje.Eroare);
            }
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            if (this.Salveaza() == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Salveaza()
        {
            try
            {

                Pacient pacient = new Pacient();

                pacient.Nume = textBoxNume.Text;
                pacient.Prenume = textBoxPrenume.Text;
                pacient.CNP = textBoxCNP.Text;
                pacient.CardSanatate = textBoxCardSanatate.Text;
                pacient.Ocupatie = textBoxOcupatie.Text;


                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    if (pacientId == 0)
                    {
                        new ActivitateService(dc).AddPacient(pacient);
                    }
                    else
                    {
                        pacient.PacientId = pacientId;
                        new ActivitateService(dc).UpdatePacient(pacient);
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

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

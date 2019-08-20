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
    public partial class FereastraAngajati : Telerik.WinControls.UI.RadForm
    {
        public FereastraAngajati()
        {
            InitializeComponent();
            this.IncarcaImagini();
        }

        private void IncarcaImagini()
        {
            this.buttonIesire.Image = PoliclinicaResurse.Back_32;
            this.buttonAdauga.Image = PoliclinicaResurse.Adauga_angajat_32;
            this.buttonModifica.Image = PoliclinicaResurse.Modificare_angajat_32;
            this.buttonSterge.Image = PoliclinicaResurse.Delete_32;
            this.buttonOrar.Image = PoliclinicaResurse.Orar_utilizatori_32;
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if(new FereastraAdaugaUtilizator().ShowDialog() == DialogResult.OK)
            {
                this.loadUtilizatoriControl1.IncarcaUtilizatori();
            }
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            if (new FereastraAdaugaUtilizator(this.loadUtilizatoriControl1.GetUtilizatorSelectat.UtilizatorId).ShowDialog() == DialogResult.OK)
            {
                this.loadUtilizatoriControl1.IncarcaUtilizatori();
            }
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            var utilizator = this.loadUtilizatoriControl1.GetUtilizatorSelectat;

            if (utilizator == null)
                return;

            try
            {
                if (RadMessageBox.Show("Doriti sa stergeti angajatul '" + utilizator.Nume + "'?", TipuriMesaje.Atentionare.ToString(), MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                    {
                        new UtilizatoriService(dc).DeleteUtilizatorById(utilizator.UtilizatorId);
                    }

                    Mesaje.Afiseaza(TextMesaje.STERGERE, TipuriMesaje.Informare);
                    this.loadUtilizatoriControl1.IncarcaUtilizatori();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_STERGERE + "\n" + ex.Message, TipuriMesaje.Eroare);
            }
        }

        private void buttonOrar_Click(object sender, EventArgs e)
        {
            new FereastraEditareOrarUtilizator(this.loadUtilizatoriControl1.GetUtilizatorSelectat.UtilizatorId).ShowDialog();
        }
    }
}

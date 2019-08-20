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
    public partial class FereastraEditareOrarUtilizator : Telerik.WinControls.UI.RadForm
    {
        int utilizatorId = 0;
        public FereastraEditareOrarUtilizator(int id)
        {
            InitializeComponent();
            this.utilizatorId = id;
            this.IncarcaDate(utilizatorId);
            this.IncarcaImagini();
        }

        private void IncarcaImagini()
        {
            this.buttonIesire.Image = PoliclinicaResurse.Back_32;
            this.buttonSalveaza.Image = this.buttonSalveazaInchide.Image = PoliclinicaResurse.Save_32;
        }

        private void IncarcaDate(int utilizatorId)
        {
            this.controlAdaugaOrarUtilizatori1.IncarcaZile(utilizatorId);
        }


        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSalveazaInchide_Click(object sender, EventArgs e)
        {
            this.Salveaza();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            this.Salveaza();
            this.IncarcaDate(utilizatorId);
        }

        private void Salveaza()
        {
            var orar = this.controlAdaugaOrarUtilizatori1.GetOrarUtilizator();
            if (orar != null)
            {
                try
                {
                    using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                    {
                        UtilizatoriService service = new UtilizatoriService(dc);
                        var utilizator = service.GetUtilizatorById(utilizatorId);
                        foreach (var zi in orar)
                        {
                            try
                            {
                                if (zi.OrarId == 0)
                                {
                                    zi.Utilizatori = utilizator;
                                    service.AddOrarUtilizator(zi);
                                }
                                else
                                {
                                    service.UpdateOrarUtilizator(zi);
                                }
                            }
                            catch (Exception ex)
                            {
                                Mesaje.Afiseaza(TextMesaje.EROARE_SALVARE + "\n" + ex.Message, TipuriMesaje.Eroare);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mesaje.Afiseaza(TextMesaje.EROARE_SALVARE + "\n" + ex.Message, TipuriMesaje.Eroare);
                    throw;
                }
            }
        }
    }
}

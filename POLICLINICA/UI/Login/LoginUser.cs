using Policlinica.Data;
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

namespace POLICLINICA.UI
{
    public partial class LoginUser : Telerik.WinControls.UI.RadForm
    {
        public LoginUser()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ThemeResolutionService.ApplicationThemeName = "Office2010Silver";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var parola = Unelte.CriptareParola(this.textBoxParola.Text);
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                Program.UtilizatorCurent = new ProceduriStocateService(dc).LoginUserPoliclinica(this.textBoxUtilizator.Text, parola);
            }
            if (Program.UtilizatorCurent != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_CONECTARE, TipuriMesaje.Eroare);
            }
        }

        private void buttonAnulare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

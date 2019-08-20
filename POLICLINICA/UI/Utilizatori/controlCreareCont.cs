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
using Policlinica.Data;
using Policlinica.Data.Services;
using POLICLINICA.Mesagerie;

namespace POLICLINICA.UI
{
    public partial class controlCreareCont : UserControl
    {
        public controlCreareCont()
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

        public Policlinica.Entities.LoginUser GetLoginUser()
        {
            Policlinica.Entities.LoginUser user = new Policlinica.Entities.LoginUser();
            user.UserName = this.textBoxUtilizator.Text;
            user.Parola = Unelte.CriptareParola(this.textBoxParola.Text);
            user.DataInregistrare = DateTime.Now;

            return user;
        }

        private void textBoxUtilizator_Validated(object sender, EventArgs e)
        {
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                if(new UtilizatoriService(dc).ExistaUserName(this.textBoxUtilizator.Text))
                {
                    Mesaje.Afiseaza(TextMesaje.UTILIZATOR_EXISTENT, TipuriMesaje.Atentionare);
                    this.textBoxUtilizator.Text = string.Empty;
                }
            }
        }

        private void textBoxConfirmaParola_Validated(object sender, EventArgs e)
        {
            if(this.textBoxParola.Text != textBoxConfirmaParola.Text)
            {
                Mesaje.Afiseaza(TextMesaje.PAROLE_DIFERITE, TipuriMesaje.Atentionare);
                this.textBoxConfirmaParola.Text = string.Empty;
            }
        }
    }
}

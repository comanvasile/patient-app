using Policlinica.Data.Services;
using Policlinica.Entities;
using Policlinica.Resurse;
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
    public partial class FereastraPacienti : Telerik.WinControls.UI.RadForm
    {
        public FereastraPacienti()
        {
            InitializeComponent();
            this.IncarcaPacienti();
            this.IncarcaImagini();
        }

        private void IncarcaImagini()
        {
            this.buttonIesire.Image = PoliclinicaResurse.Back_32;
            this.buttonAdauga.Image = PoliclinicaResurse.Adauga_pacient_32;
            this.buttonModifica.Image = PoliclinicaResurse.Modificare_angajat_32;
            this.buttonIstoricPacient.Image = PoliclinicaResurse.Istoric_pacient_32;
        }

        private void IncarcaPacienti()
        {
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                this.gridPacienti.BeginUpdate();
                this.gridPacienti.DataSource = new ActivitateService(dc).GetPacientiAll();
                this.gridPacienti.EndUpdate();
            }
        }

        public Pacient PacientSelectat
        {
            get
            {
                return this.gridPacienti.CurrentRow.DataBoundItem as Pacient;
            }
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if(new FereastraAdaugaPacienti().ShowDialog() == DialogResult.OK)
            {
                this.IncarcaPacienti();
            }
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            if(gridPacienti.CurrentRow != null && gridPacienti.CurrentRow.DataBoundItem != null)
                if (new FereastraAdaugaPacienti(PacientSelectat.PacientId).ShowDialog() == DialogResult.OK)
                {
                    this.IncarcaPacienti();
                }
        }

        private void buttonIstoricPacient_Click(object sender, EventArgs e)
        {
            new FereastraIstoricPacient(PacientSelectat.PacientId).ShowDialog();
        }
    }
}

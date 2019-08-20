using Policlinica.Data.Enums;
using Policlinica.Resurse;
using POLICLINICA.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POLICLINICA
{
    public partial class MainPoliclinica : Telerik.WinControls.UI.RadForm
    {
        private readonly Dictionary<object, IList<RoluriAcces>> roluri;

        public MainPoliclinica()
        {
            InitializeComponent();
            this.IncarcaImagini();
            this.roluri = new Dictionary<object, IList<RoluriAcces>>();
            this.SetareAccesRol();
        }

        private void SetareAccesRol()
        { 
            roluri.Add(this.groupHRActiuni, new List<RoluriAcces>() { RoluriAcces.Asistent, RoluriAcces.Medic, RoluriAcces.Receptioner,RoluriAcces.Financiar });
            roluri.Add(this.tabContabilitate, new List<RoluriAcces>() { RoluriAcces.HR, RoluriAcces.Asistent, RoluriAcces.Receptioner });
            roluri.Add(this.groupContabilitateActiuni, new List<RoluriAcces>() { RoluriAcces.Medic });
            roluri.Add(this.groupActivitateMedic, new List<RoluriAcces>() { RoluriAcces.Financiar, RoluriAcces.Administrator, RoluriAcces.SuperAdministrator });
            roluri.Add(this.tabActivitate, new List<RoluriAcces>() { RoluriAcces.HR, RoluriAcces.Financiar });
            roluri.Add(this.groupActivitateActiuni, new List<RoluriAcces>() { RoluriAcces.Asistent, RoluriAcces.Medic, RoluriAcces.Administrator });
            roluri.Add(this.buttonAdaugaProgramare, new List<RoluriAcces>() { RoluriAcces.Asistent, RoluriAcces.Medic });
            roluri.Add(this.buttonPacienti, new List<RoluriAcces>() { RoluriAcces.Asistent, RoluriAcces.Medic });
            roluri.Add(this.buttonActivitateMedic, new List<RoluriAcces> { RoluriAcces.SuperAdministrator, RoluriAcces.Receptioner, RoluriAcces.Administrator });

            foreach (var item in roluri)
            {
                if(item.Value.Contains((RoluriAcces)Program.UtilizatorCurent.Fk_RolId))
                {
                    var item2 = item.Key;
                    ((IDisposable)item2).Dispose();
                }
            }
        }

        private void IncarcaImagini()
        {
            pictureBox1.Image = Policlinica.Resurse.PoliclinicaResurse.prima_pagina;
            this.buttonAngajati.Image = PoliclinicaResurse.Angajati_32;
            this.buttonVizualiziareDate.Image = PoliclinicaResurse.Vizualizare_date_32;
            this.buttonProfitPoliclinici.Image = PoliclinicaResurse.Profit_32;
            this.buttonSalariiMedic.Image = PoliclinicaResurse.Salarii_medic_32;
            this.ButtonAdaugareSpecialitati.Image = PoliclinicaResurse.Adauga_specialitati_medic_32;
            this.buttonAdaugaProgramare.Image = PoliclinicaResurse.Adauga_programare_32;
            this.buttonPacienti.Image = PoliclinicaResurse.Pacienti_32;
            this.buttonActivitateMedic.Image = PoliclinicaResurse.Activitate_medic_32;
        }

        private void menuButtonDeconectare_Click(object sender, EventArgs e)
        {
            Program.Restart = true;
            this.Close();
        }

        private void buttonAngajati_Click(object sender, EventArgs e)
        {
            new FereastraAngajati().ShowDialog();
        }

        private void buttonAdaugaUnitateMedicala_Click(object sender, EventArgs e)
        {
            new FereastraAdaugaUnitateMedicala().ShowDialog();
        }

        private void buttonVizualiziareDate_Click(object sender, EventArgs e)
        {
            new FereastraVizualizareDatePersonale().ShowDialog();
        }

        private void ButtonAdaugareSpecialitati_Click(object sender, EventArgs e)
        {
            new FereastraAdaugaSpecialitatiMedic().ShowDialog();
        }

        private void buttonAdaugaProgramare_Click(object sender, EventArgs e)
        {
            new FereastraAdaugaProgramare().ShowDialog();
        }

        private void buttonPacienti_Click(object sender, EventArgs e)
        {
            new FereastraPacienti().ShowDialog();
        }

        private void buttonActivitateMedic_Click(object sender, EventArgs e)
        {
            new FereastraActivitateMedic().ShowDialog();
        }

        private void buttonProfitPoliclinici_Click(object sender, EventArgs e)
        {
            new VizualizareProfit().ShowDialog();
        }

        private void buttonSalariiMedic_Click(object sender, EventArgs e)
        {
            new FereastraVizualizareSalariiMedic().ShowDialog();        
        }
    }
}

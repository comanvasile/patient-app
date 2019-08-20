using Policlinica.Data.Models;
using Policlinica.Data.Services;
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
    public partial class FereastraAdaugaUtilizator : Telerik.WinControls.UI.RadForm
    {
        int utilizatorId = 0;

        public FereastraAdaugaUtilizator()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = "Office2010Silver";
        }

        public FereastraAdaugaUtilizator(int id)
        {
            InitializeComponent();
            this.utilizatorId = id;
            this.IncarcaUtilizator(id);
            DisposePages();

        }

        private void DisposePages()
        {
            this.radWizard1.Pages[0].Title = "Modificare utilizator";
            this.radWizard1.Pages[4].Title = "Cont";
            this.controlAdaugaOrarUtilizatori1.Dispose();
            this.radWizard1.Pages[3].Dispose();
            this.radWizard1.Pages[3] = this.radWizard1.Pages[4];
            this.controlCreareCont1.Dispose();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                base.OnLoad(e);
                this.controlAdaugaOrarUtilizatori1.IncarcaZile();
            }
        }

        private void IncarcaUtilizator(int id)
        {
            Utilizatori utilizator;
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                utilizator = new UtilizatoriService(dc).GetUtilizatorById(id);

                this.controlAdaugaUtilizator1.SetUtilizator(utilizator);
                if (utilizator.Medic != null)
                {
                    this.controlAdaugaMedic1.SetMedic(utilizator.Medic);
                }
                if (utilizator.AsistentMedical != null)
                {
                    this.controlAdaugaAsistentMedical1.SetAsistentMedical(utilizator.AsistentMedical);
                }
                
            }
        }

        private void radWizard1_Next(object sender, Telerik.WinControls.UI.WizardCancelEventArgs e)
        {
            String functie = this.controlAdaugaUtilizator1.GetFunctie();
            if(this.radWizard1.SelectedPage == this.radWizard1.Pages[1])
            {
                e.Cancel = true;
                this.radWizard1.SelectedPage = this.radWizard1.Pages[3];
            }
            if (this.radWizard1.SelectedPage == this.radWizard1.Pages[0])
            {
                if (functie == "Medic")
                {
                    e.Cancel = true;
                    this.radWizard1.SelectedPage = this.radWizard1.Pages[1];
                }
                else
                {
                    if (functie == "Asistent medical")
                    {
                        e.Cancel = true;
                        this.radWizard1.SelectedPage = this.radWizard1.Pages[2];
                    }
                    else
                    {
                        e.Cancel = true;
                        this.radWizard1.SelectedPage = this.radWizard1.Pages[3];
                    }
                }
            }
        }

        private void radWizard1_Cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radWizard1_Finish(object sender, EventArgs e)
        {
            try
            {
                Utilizatori utilizator = null;
                using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
                {
                    var service = new UtilizatoriService(dc);
                    utilizator = controlAdaugaUtilizator1.GetUtilizator();
                    if (utilizatorId == 0)
                    {
                        if (controlAdaugaUtilizator1.GetFunctie() == "Medic")
                            utilizator.Medic = controlAdaugaMedic1.GetMedic();
                        if (controlAdaugaUtilizator1.GetFunctie() == "Asistent medical")
                            utilizator.AsistentMedical = controlAdaugaAsistentMedical1.GetAsistentMedical();
                        utilizator.OrarUtilizatori = controlAdaugaOrarUtilizatori1.GetOrarUtilizator();
                        utilizator.LoginUser = controlCreareCont1.GetLoginUser();

                        service.AddUtilizator(utilizator);
                        //new UtilizatoriService(dc).AddUtilizator(utilizator, controlAdaugaMedic1.GetMedic(), controlAdaugaOrarUtilizatori1.GetOrarUtilizator(), controlCreareCont1.GetLoginUser());
                    }
                    else
                    {
                        utilizator = service.GetUtilizatorById(utilizatorId);
                        utilizator = controlAdaugaUtilizator1.GetUtilizator(utilizator);
                        if (controlAdaugaUtilizator1.GetFunctie() == "Medic")
                        {
                            utilizator.Medic = controlAdaugaMedic1.GetMedic(utilizator.Medic);
                            utilizator.AsistentMedical = null;
                        }
                        if (controlAdaugaUtilizator1.GetFunctie() == "Asistent medical")
                        {
                            utilizator.AsistentMedical = controlAdaugaAsistentMedical1.GetAsistentMedical(utilizator.AsistentMedical);
                            utilizator.Medic = null;
                        }

                        service.UpdateUtilizator(utilizator);
                    }
                }

                Mesaje.Afiseaza(TextMesaje.SALVARE, TipuriMesaje.Informare);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                Mesaje.Afiseaza(TextMesaje.EROARE_SALVARE + "\n" +ex.Message, TipuriMesaje.Eroare);
                this.radWizard1.SelectedPage = this.radWizard1.Pages[4];
            }
        }

        private void radWizard1_Previous(object sender, Telerik.WinControls.UI.WizardCancelEventArgs e)
        {
            String functie = this.controlAdaugaUtilizator1.GetFunctie();
            if (this.radWizard1.SelectedPage == this.radWizard1.Pages[2])
            {
                e.Cancel = true;
                this.radWizard1.SelectedPage = this.radWizard1.Pages[0];
            }
            else
            {
                if(this.radWizard1.SelectedPage == this.radWizard1.Pages[3])
                {
                    if (functie == "Medic")
                    {
                        e.Cancel = true;
                        this.radWizard1.SelectedPage = this.radWizard1.Pages[1];
                    }
                    else
                    {
                        if (functie == "Asistent medical")
                        {
                            e.Cancel = true;
                            this.radWizard1.SelectedPage = this.radWizard1.Pages[2];
                        }
                        else
                        {
                            e.Cancel = true;
                            this.radWizard1.SelectedPage = this.radWizard1.Pages[0];
                        }
                    }
                }
            }
        }
    }
}

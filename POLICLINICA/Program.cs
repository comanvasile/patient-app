using Policlinica.Data.Models;
using Policlinica.Data.Services;
using Policlinica.Entities;
using POLICLINICA.UI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace POLICLINICA
{
    static class Program
    {
        public static UtilizatorModel UtilizatorCurent;
        public static bool Restart = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FereastraAdaugaUtilizator());
            if (ExistaUnitateMedicala())
            {
                if (ExistaUtilizatori())
                {
                    if (new POLICLINICA.UI.LoginUser().ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new MainPoliclinica());
                    }
                }
                else
                {
                    if (new FereastraAdaugaUtilizator().ShowDialog() == DialogResult.OK)
                    {
                        if (new POLICLINICA.UI.LoginUser().ShowDialog() == DialogResult.OK)
                        {
                            Application.Run(new MainPoliclinica());
                        }
                    }
                }
            }
            else
            {
                if (new FereastraAdaugaUnitateMedicala().ShowDialog() == DialogResult.OK)
                {
                    if (new FereastraAdaugaUtilizator().ShowDialog() == DialogResult.OK)
                    {
                        if (new POLICLINICA.UI.LoginUser().ShowDialog() == DialogResult.OK)
                        {
                            Application.Run(new MainPoliclinica());
                        }
                    }
                }
            }
            if(Restart)
            {
                Restart = false;
                Application.Restart();
            }

        }

        private static bool ExistaUnitateMedicala()
        {
            bool exista;
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                exista = new UtilizatoriService(dc).ExistaUnitateMedicala();
            }
            return exista;
        }
        private static bool ExistaUtilizatori()
        {
            bool exista;
            using (PoliclinicaDataContext dc = new PoliclinicaDataContext())
            {
                exista = new UtilizatoriService(dc).ExistaUtilizatori();
            }
            return exista;
        }
    }
}
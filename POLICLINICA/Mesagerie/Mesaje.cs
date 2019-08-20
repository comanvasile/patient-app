using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;

namespace POLICLINICA.Mesagerie
{
    public static class Mesaje
    {
        public static void Afiseaza(String mesaj, object tip)
        {
            RadMessageBox.Show(mesaj, ((TipuriMesaje)tip).ToString());
        }
    }
}

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
using Policlinica.Data.Enums;

namespace POLICLINICA.UI
{
    public partial class controlAdaugaAsistentMedical : UserControl
    {
        public controlAdaugaAsistentMedical()
        {
            InitializeComponent();
            this.IncarcaDate();
         }

        protected override void OnLoad(EventArgs e)
        {
            if(!DesignMode)
            {
                base.OnLoad(e);
            }
        }

        private void IncarcaDate()
        {
            this.dropDownGrad.DataSource = Unelte.GetEnumValues(typeof(GradAsistentMedical));
            this.dropDownTip.DataSource = Unelte.GetEnumValues(typeof(TipAsistentMedical));
            this.dropDownGrad.ValueMember = this.dropDownTip.ValueMember = "Key";
            this.dropDownGrad.DisplayMember = this.dropDownTip.DisplayMember = "Value";
        }


        public AsistentMedical GetAsistentMedical()
        {
            AsistentMedical asistent = new AsistentMedical();
            asistent.Grad = (int)dropDownGrad.SelectedValue;
            asistent.Tip = (int)dropDownTip.SelectedValue;

            return asistent;
        }

        public void SetAsistentMedical(AsistentMedical asistentMedical)
        {
            this.dropDownGrad.SelectedValue = asistentMedical.Grad;
            this.dropDownTip.SelectedValue = asistentMedical.Tip;
        }

        public AsistentMedical GetAsistentMedical(AsistentMedical asistent)
        {
            if (asistent == null)
                asistent = new AsistentMedical();
            asistent.Grad = (int)dropDownGrad.SelectedValue;
            asistent.Tip = (int)dropDownTip.SelectedValue;

            return asistent;
        }
    }
}

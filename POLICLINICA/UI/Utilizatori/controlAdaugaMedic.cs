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
using Policlinica.Data.Enums;
using Policlinica.Data;

namespace POLICLINICA.UI
{
    public partial class controlAdaugaMedic : UserControl
    {
        public controlAdaugaMedic()
        {
            InitializeComponent();
            this.IncarcaDate();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                base.OnLoad(e);
            }
        }

        private void IncarcaDate()
        {
            this.dropDownGrad.DataSource = Unelte.GetEnumValues(typeof(GradMedic));
            this.dropDownTitlu.DataSource = Unelte.GetEnumValues(typeof(TitluStiintific));
            this.dropDownPostDidactic.DataSource = Unelte.GetEnumValues(typeof(PostDidactic));
            this.dropDownGrad.ValueMember = this.dropDownTitlu.ValueMember = this.dropDownPostDidactic.ValueMember = "Key";
            this.dropDownGrad.DisplayMember = this.dropDownTitlu.DisplayMember = this.dropDownPostDidactic.DisplayMember = "Value";
        }

        public Medic GetMedic()
        {
            Medic medic = new Medic();
            medic.Grad = (int)dropDownGrad.SelectedValue;
            medic.CodulDeParafa = this.textBoxParafa.Text;
            medic.TitlulStiintific = (int)dropDownTitlu.SelectedValue;
            medic.PostulDidactic = (int)dropDownPostDidactic.SelectedValue;
            medic.ProcentServicii = this.spinEditorProcentServicii.Value;

            return medic;
        }

        public void SetMedic(Medic medic)
        {
            this.dropDownGrad.SelectedValue = medic.Grad;
            this.textBoxParafa.Text = medic.CodulDeParafa;
            this.dropDownTitlu.SelectedValue = medic.TitlulStiintific;
            this.dropDownPostDidactic.SelectedValue = medic.PostulDidactic;
            this.spinEditorProcentServicii.Value = (decimal)medic.ProcentServicii;
        }

        public Medic GetMedic(Medic medic)
        {
            if (medic == null)
                medic = new Medic();
            medic.Grad = (int)dropDownGrad.SelectedValue;
            medic.CodulDeParafa = this.textBoxParafa.Text;
            medic.TitlulStiintific = (int)this.dropDownTitlu.SelectedValue;
            medic.PostulDidactic = (int)this.dropDownPostDidactic.SelectedValue;
            medic.ProcentServicii = this.spinEditorProcentServicii.Value;

            return medic;
        }
    }
}

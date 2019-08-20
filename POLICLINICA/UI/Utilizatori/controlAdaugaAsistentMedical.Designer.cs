namespace POLICLINICA.UI
{
    partial class controlAdaugaAsistentMedical
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAsistentMedical = new Telerik.WinControls.UI.RadGroupBox();
            this.labelGrad = new Telerik.WinControls.UI.RadLabel();
            this.dropDownTip = new Telerik.WinControls.UI.RadDropDownList();
            this.dropDownGrad = new Telerik.WinControls.UI.RadDropDownList();
            this.labelTip = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxAsistentMedical)).BeginInit();
            this.groupBoxAsistentMedical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelGrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownGrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTip)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAsistentMedical
            // 
            this.groupBoxAsistentMedical.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBoxAsistentMedical.Controls.Add(this.labelGrad);
            this.groupBoxAsistentMedical.Controls.Add(this.dropDownTip);
            this.groupBoxAsistentMedical.Controls.Add(this.dropDownGrad);
            this.groupBoxAsistentMedical.Controls.Add(this.labelTip);
            this.groupBoxAsistentMedical.HeaderText = "Asistent medical";
            this.groupBoxAsistentMedical.Location = new System.Drawing.Point(20, 23);
            this.groupBoxAsistentMedical.Name = "groupBoxAsistentMedical";
            this.groupBoxAsistentMedical.Size = new System.Drawing.Size(256, 114);
            this.groupBoxAsistentMedical.TabIndex = 5;
            this.groupBoxAsistentMedical.Text = "Asistent medical";
            // 
            // labelGrad
            // 
            this.labelGrad.Location = new System.Drawing.Point(20, 35);
            this.labelGrad.Name = "labelGrad";
            this.labelGrad.Size = new System.Drawing.Size(33, 18);
            this.labelGrad.TabIndex = 10;
            this.labelGrad.Text = "Grad:";
            // 
            // dropDownTip
            // 
            this.dropDownTip.Location = new System.Drawing.Point(65, 67);
            this.dropDownTip.Name = "dropDownTip";
            this.dropDownTip.Size = new System.Drawing.Size(177, 20);
            this.dropDownTip.TabIndex = 2;
            // 
            // dropDownGrad
            // 
            this.dropDownGrad.Location = new System.Drawing.Point(65, 35);
            this.dropDownGrad.Name = "dropDownGrad";
            this.dropDownGrad.Size = new System.Drawing.Size(177, 20);
            this.dropDownGrad.TabIndex = 0;
            // 
            // labelTip
            // 
            this.labelTip.Location = new System.Drawing.Point(29, 67);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(24, 18);
            this.labelTip.TabIndex = 5;
            this.labelTip.Text = "Tip:";
            // 
            // controlAdaugaAsistentMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAsistentMedical);
            this.Name = "controlAdaugaAsistentMedical";
            this.Size = new System.Drawing.Size(358, 254);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxAsistentMedical)).EndInit();
            this.groupBoxAsistentMedical.ResumeLayout(false);
            this.groupBoxAsistentMedical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelGrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownGrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox groupBoxAsistentMedical;
        private Telerik.WinControls.UI.RadLabel labelGrad;
        private Telerik.WinControls.UI.RadDropDownList dropDownTip;
        private Telerik.WinControls.UI.RadDropDownList dropDownGrad;
        private Telerik.WinControls.UI.RadLabel labelTip;
    }
}

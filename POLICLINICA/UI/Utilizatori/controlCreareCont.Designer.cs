namespace POLICLINICA.UI
{
    partial class controlCreareCont
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
            this.groupBoxCont = new Telerik.WinControls.UI.RadGroupBox();
            this.labelConfirmaParola = new Telerik.WinControls.UI.RadLabel();
            this.textBoxConfirmaParola = new Telerik.WinControls.UI.RadTextBox();
            this.textBoxParola = new Telerik.WinControls.UI.RadTextBox();
            this.textBoxUtilizator = new Telerik.WinControls.UI.RadTextBox();
            this.labelParola = new Telerik.WinControls.UI.RadLabel();
            this.labelUtilizator = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxCont)).BeginInit();
            this.groupBoxCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelConfirmaParola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxConfirmaParola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxParola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUtilizator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelParola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelUtilizator)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCont
            // 
            this.groupBoxCont.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBoxCont.Controls.Add(this.labelConfirmaParola);
            this.groupBoxCont.Controls.Add(this.textBoxConfirmaParola);
            this.groupBoxCont.Controls.Add(this.textBoxParola);
            this.groupBoxCont.Controls.Add(this.textBoxUtilizator);
            this.groupBoxCont.Controls.Add(this.labelParola);
            this.groupBoxCont.Controls.Add(this.labelUtilizator);
            this.groupBoxCont.HeaderText = "Cont";
            this.groupBoxCont.Location = new System.Drawing.Point(31, 27);
            this.groupBoxCont.Name = "groupBoxCont";
            this.groupBoxCont.Size = new System.Drawing.Size(281, 127);
            this.groupBoxCont.TabIndex = 1;
            this.groupBoxCont.Text = "Cont";
            // 
            // labelConfirmaParola
            // 
            this.labelConfirmaParola.Location = new System.Drawing.Point(6, 87);
            this.labelConfirmaParola.Name = "labelConfirmaParola";
            this.labelConfirmaParola.Size = new System.Drawing.Size(89, 18);
            this.labelConfirmaParola.TabIndex = 4;
            this.labelConfirmaParola.Text = "Confirma parola:";
            // 
            // textBoxConfirmaParola
            // 
            this.textBoxConfirmaParola.Location = new System.Drawing.Point(107, 86);
            this.textBoxConfirmaParola.Name = "textBoxConfirmaParola";
            this.textBoxConfirmaParola.PasswordChar = '*';
            this.textBoxConfirmaParola.Size = new System.Drawing.Size(164, 20);
            this.textBoxConfirmaParola.TabIndex = 2;
            this.textBoxConfirmaParola.Validated += new System.EventHandler(this.textBoxConfirmaParola_Validated);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(107, 60);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(164, 20);
            this.textBoxParola.TabIndex = 1;
            // 
            // textBoxUtilizator
            // 
            this.textBoxUtilizator.Location = new System.Drawing.Point(107, 34);
            this.textBoxUtilizator.Name = "textBoxUtilizator";
            this.textBoxUtilizator.Size = new System.Drawing.Size(164, 20);
            this.textBoxUtilizator.TabIndex = 0;
            this.textBoxUtilizator.Validated += new System.EventHandler(this.textBoxUtilizator_Validated);
            // 
            // labelParola
            // 
            this.labelParola.Location = new System.Drawing.Point(55, 61);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(40, 18);
            this.labelParola.TabIndex = 3;
            this.labelParola.Text = "Parola:";
            // 
            // labelUtilizator
            // 
            this.labelUtilizator.Location = new System.Drawing.Point(9, 35);
            this.labelUtilizator.Name = "labelUtilizator";
            this.labelUtilizator.Size = new System.Drawing.Size(86, 18);
            this.labelUtilizator.TabIndex = 2;
            this.labelUtilizator.Text = "Nume utilizator:";
            // 
            // controlCreareCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCont);
            this.Name = "controlCreareCont";
            this.Size = new System.Drawing.Size(342, 235);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxCont)).EndInit();
            this.groupBoxCont.ResumeLayout(false);
            this.groupBoxCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelConfirmaParola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxConfirmaParola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxParola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUtilizator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelParola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelUtilizator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox groupBoxCont;
        private Telerik.WinControls.UI.RadTextBox textBoxConfirmaParola;
        private Telerik.WinControls.UI.RadTextBox textBoxParola;
        private Telerik.WinControls.UI.RadTextBox textBoxUtilizator;
        private Telerik.WinControls.UI.RadLabel labelParola;
        private Telerik.WinControls.UI.RadLabel labelUtilizator;
        private Telerik.WinControls.UI.RadLabel labelConfirmaParola;
    }
}

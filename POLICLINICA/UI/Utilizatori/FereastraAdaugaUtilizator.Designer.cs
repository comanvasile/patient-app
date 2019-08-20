namespace POLICLINICA.UI
{
    partial class FereastraAdaugaUtilizator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FereastraAdaugaUtilizator));
            this.radWizard1 = new Telerik.WinControls.UI.RadWizard();
            this.wizardCompletionPage1 = new Telerik.WinControls.UI.WizardCompletionPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.wizardWelcomePage1 = new Telerik.WinControls.UI.WizardWelcomePage();
            this.wizardPage1 = new Telerik.WinControls.UI.WizardPage();
            this.wizardPage2 = new Telerik.WinControls.UI.WizardPage();
            this.wizardPage3 = new Telerik.WinControls.UI.WizardPage();
            this.controlCreareCont1 = new POLICLINICA.UI.controlCreareCont();
            this.controlAdaugaUtilizator1 = new POLICLINICA.UI.controlAdaugaUtilizator();
            this.controlAdaugaMedic1 = new POLICLINICA.UI.controlAdaugaMedic();
            this.controlAdaugaAsistentMedical1 = new POLICLINICA.UI.controlAdaugaAsistentMedical();
            this.controlAdaugaOrarUtilizatori1 = new POLICLINICA.UI.controlAdaugaOrarUtilizatori();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radWizard1)).BeginInit();
            this.radWizard1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radWizard1
            // 
            this.radWizard1.CompletionPage = this.wizardCompletionPage1;
            this.radWizard1.Controls.Add(this.panel1);
            this.radWizard1.Controls.Add(this.panel2);
            this.radWizard1.Controls.Add(this.panel3);
            this.radWizard1.Controls.Add(this.panel4);
            this.radWizard1.Controls.Add(this.panel5);
            this.radWizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radWizard1.Location = new System.Drawing.Point(0, 0);
            this.radWizard1.Name = "radWizard1";
            this.radWizard1.PageHeaderIcon = ((System.Drawing.Image)(resources.GetObject("radWizard1.PageHeaderIcon")));
            this.radWizard1.Pages.Add(this.wizardWelcomePage1);
            this.radWizard1.Pages.Add(this.wizardPage1);
            this.radWizard1.Pages.Add(this.wizardPage2);
            this.radWizard1.Pages.Add(this.wizardPage3);
            this.radWizard1.Pages.Add(this.wizardCompletionPage1);
            this.radWizard1.Size = new System.Drawing.Size(785, 575);
            this.radWizard1.TabIndex = 0;
            this.radWizard1.WelcomePage = this.wizardWelcomePage1;
            this.radWizard1.Next += new Telerik.WinControls.UI.WizardCancelEventHandler(this.radWizard1_Next);
            this.radWizard1.Previous += new Telerik.WinControls.UI.WizardCancelEventHandler(this.radWizard1_Previous);
            this.radWizard1.Finish += new System.EventHandler(this.radWizard1_Finish);
            this.radWizard1.Cancel += new System.EventHandler(this.radWizard1_Cancel);
            // 
            // wizardCompletionPage1
            // 
            this.wizardCompletionPage1.ContentArea = this.panel3;
            this.wizardCompletionPage1.Header = "";
            this.wizardCompletionPage1.Name = "wizardCompletionPage1";
            this.wizardCompletionPage1.Title = "Creare cont";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.controlCreareCont1);
            this.panel3.Location = new System.Drawing.Point(150, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 471);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.controlAdaugaUtilizator1);
            this.panel1.Location = new System.Drawing.Point(150, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 471);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.controlAdaugaMedic1);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 463);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.controlAdaugaAsistentMedical1);
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 463);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.controlAdaugaOrarUtilizatori1);
            this.panel5.Location = new System.Drawing.Point(0, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(785, 463);
            this.panel5.TabIndex = 4;
            // 
            // wizardWelcomePage1
            // 
            this.wizardWelcomePage1.ContentArea = this.panel1;
            this.wizardWelcomePage1.Header = "Page header";
            this.wizardWelcomePage1.Name = "wizardWelcomePage1";
            this.wizardWelcomePage1.Title = "Adauga utilizator";
            // 
            // wizardPage1
            // 
            this.wizardPage1.ContentArea = this.panel2;
            this.wizardPage1.Header = "";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Title = "Medic";
            // 
            // wizardPage2
            // 
            this.wizardPage2.ContentArea = this.panel4;
            this.wizardPage2.Header = "";
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Title = "Asistent medical";
            // 
            // wizardPage3
            // 
            this.wizardPage3.ContentArea = this.panel5;
            this.wizardPage3.Header = "";
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Title = "Orar utilizator";
            // 
            // controlCreareCont1
            // 
            this.controlCreareCont1.Location = new System.Drawing.Point(3, 3);
            this.controlCreareCont1.Name = "controlCreareCont1";
            this.controlCreareCont1.Size = new System.Drawing.Size(342, 235);
            this.controlCreareCont1.TabIndex = 0;
            // 
            // controlAdaugaUtilizator1
            // 
            this.controlAdaugaUtilizator1.Location = new System.Drawing.Point(3, 3);
            this.controlAdaugaUtilizator1.Name = "controlAdaugaUtilizator1";
            this.controlAdaugaUtilizator1.Size = new System.Drawing.Size(583, 456);
            this.controlAdaugaUtilizator1.TabIndex = 0;
            // 
            // controlAdaugaMedic1
            // 
            this.controlAdaugaMedic1.Location = new System.Drawing.Point(12, 13);
            this.controlAdaugaMedic1.Name = "controlAdaugaMedic1";
            this.controlAdaugaMedic1.Size = new System.Drawing.Size(377, 296);
            this.controlAdaugaMedic1.TabIndex = 0;
            // 
            // controlAdaugaAsistentMedical1
            // 
            this.controlAdaugaAsistentMedical1.Location = new System.Drawing.Point(12, 15);
            this.controlAdaugaAsistentMedical1.Name = "controlAdaugaAsistentMedical1";
            this.controlAdaugaAsistentMedical1.Size = new System.Drawing.Size(358, 254);
            this.controlAdaugaAsistentMedical1.TabIndex = 0;
            // 
            // controlAdaugaOrarUtilizatori1
            // 
            this.controlAdaugaOrarUtilizatori1.Location = new System.Drawing.Point(3, 3);
            this.controlAdaugaOrarUtilizatori1.Name = "controlAdaugaOrarUtilizatori1";
            this.controlAdaugaOrarUtilizatori1.Size = new System.Drawing.Size(518, 325);
            this.controlAdaugaOrarUtilizatori1.TabIndex = 0;
            // 
            // FereastraAdaugaUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 575);
            this.Controls.Add(this.radWizard1);
            this.Name = "FereastraAdaugaUtilizator";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizator nou";
            ((System.ComponentModel.ISupportInitialize)(this.radWizard1)).EndInit();
            this.radWizard1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadWizard radWizard1;
        private Telerik.WinControls.UI.WizardCompletionPage wizardCompletionPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.WizardWelcomePage wizardWelcomePage1;
        private Telerik.WinControls.UI.WizardPage wizardPage1;
        private controlCreareCont controlCreareCont1;
        private controlAdaugaUtilizator controlAdaugaUtilizator1;
        private controlAdaugaMedic controlAdaugaMedic1;
        private System.Windows.Forms.Panel panel4;
        private controlAdaugaAsistentMedical controlAdaugaAsistentMedical1;
        private System.Windows.Forms.Panel panel5;
        private controlAdaugaOrarUtilizatori controlAdaugaOrarUtilizatori1;
        private Telerik.WinControls.UI.WizardPage wizardPage2;
        private Telerik.WinControls.UI.WizardPage wizardPage3;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
    }
}

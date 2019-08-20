namespace POLICLINICA.UI
{
    partial class FereastraAdaugaProgramare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FereastraAdaugaProgramare));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radWizard1 = new Telerik.WinControls.UI.RadWizard();
            this.wizardCompletionPage1 = new Telerik.WinControls.UI.WizardCompletionPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridProgramare = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.menuAdaugaPacient = new Telerik.WinControls.UI.RadMenuItem();
            this.dropDownPacienti = new Telerik.WinControls.UI.RadDropDownList();
            this.gridSpecialitati = new Telerik.WinControls.UI.RadGridView();
            this.wizardWelcomePage1 = new Telerik.WinControls.UI.WizardWelcomePage();
            ((System.ComponentModel.ISupportInitialize)(this.radWizard1)).BeginInit();
            this.radWizard1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProgramare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProgramare.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownPacienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpecialitati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpecialitati.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radWizard1
            // 
            this.radWizard1.CompletionPage = this.wizardCompletionPage1;
            this.radWizard1.Controls.Add(this.panel1);
            this.radWizard1.Controls.Add(this.panel3);
            this.radWizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radWizard1.Location = new System.Drawing.Point(0, 0);
            this.radWizard1.Name = "radWizard1";
            this.radWizard1.PageHeaderIcon = ((System.Drawing.Image)(resources.GetObject("radWizard1.PageHeaderIcon")));
            this.radWizard1.Pages.Add(this.wizardWelcomePage1);
            this.radWizard1.Pages.Add(this.wizardCompletionPage1);
            this.radWizard1.Size = new System.Drawing.Size(892, 594);
            this.radWizard1.TabIndex = 0;
            this.radWizard1.Text = "radWizard1";
            this.radWizard1.WelcomePage = this.wizardWelcomePage1;
            this.radWizard1.Next += new Telerik.WinControls.UI.WizardCancelEventHandler(this.radWizard1_Next);
            this.radWizard1.Finish += new System.EventHandler(this.radWizard1_Finish);
            this.radWizard1.Cancel += new System.EventHandler(this.radWizard1_Cancel);
            // 
            // wizardCompletionPage1
            // 
            this.wizardCompletionPage1.ContentArea = this.panel3;
            this.wizardCompletionPage1.Header = "";
            this.wizardCompletionPage1.HeaderVisibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.wizardCompletionPage1.Name = "wizardCompletionPage1";
            this.wizardCompletionPage1.Title = "Selectare medic si data programare";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.gridProgramare);
            this.panel3.Location = new System.Drawing.Point(150, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(742, 490);
            this.panel3.TabIndex = 2;
            // 
            // gridProgramare
            // 
            this.gridProgramare.BackColor = System.Drawing.Color.White;
            this.gridProgramare.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProgramare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProgramare.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridProgramare.ForeColor = System.Drawing.Color.Black;
            this.gridProgramare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridProgramare.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridProgramare.MasterTemplate.AllowAddNewRow = false;
            this.gridProgramare.MasterTemplate.AllowDeleteRow = false;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "SpecialitateId";
            gridViewDecimalColumn5.HeaderText = "SpecialitateId";
            gridViewDecimalColumn5.IsVisible = false;
            gridViewDecimalColumn5.Name = "SpecialitateId";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Nume";
            gridViewTextBoxColumn4.HeaderText = "Specialitate";
            gridViewTextBoxColumn4.MinWidth = 100;
            gridViewTextBoxColumn4.Name = "Nume";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 219;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Competenta";
            gridViewTextBoxColumn5.HeaderText = "Competenta";
            gridViewTextBoxColumn5.Name = "Competenta";
            gridViewTextBoxColumn5.Width = 92;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "Pret";
            gridViewDecimalColumn6.HeaderText = "Pret";
            gridViewDecimalColumn6.Name = "Pret";
            gridViewDecimalColumn7.DataType = typeof(int);
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "Durata";
            gridViewDecimalColumn7.HeaderText = "Durata";
            gridViewDecimalColumn7.Name = "Durata";
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.FieldName = "Medic";
            gridViewComboBoxColumn2.HeaderText = "Medic";
            gridViewComboBoxColumn2.Name = "Medic";
            gridViewComboBoxColumn2.Width = 119;
            gridViewDateTimeColumn2.EditorType = Telerik.WinControls.UI.GridViewDateTimeEditorType.TimePicker;
            gridViewDateTimeColumn2.EnableExpressionEditor = true;
            gridViewDateTimeColumn2.FieldName = "DataProgramare";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn2.FormatString = "{0: dd/MM/yyyy  | HH:mm}";
            gridViewDateTimeColumn2.HeaderText = "Data programare";
            gridViewDateTimeColumn2.Name = "DataProgramare";
            gridViewDateTimeColumn2.Width = 162;
            this.gridProgramare.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn5,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewComboBoxColumn2,
            gridViewDateTimeColumn2});
            this.gridProgramare.MasterTemplate.EnableGrouping = false;
            this.gridProgramare.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.gridProgramare.Name = "gridProgramare";
            this.gridProgramare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridProgramare.Size = new System.Drawing.Size(742, 490);
            this.gridProgramare.TabIndex = 1;
            this.gridProgramare.Text = "radGridView1";
            this.gridProgramare.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridProgramare_CellEditorInitialized);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radMenu1);
            this.panel1.Controls.Add(this.dropDownPacienti);
            this.panel1.Controls.Add(this.gridSpecialitati);
            this.panel1.Location = new System.Drawing.Point(150, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 490);
            this.panel1.TabIndex = 0;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuAdaugaPacient});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(742, 20);
            this.radMenu1.TabIndex = 3;
            this.radMenu1.Text = "radMenu1";
            // 
            // menuAdaugaPacient
            // 
            this.menuAdaugaPacient.Name = "menuAdaugaPacient";
            this.menuAdaugaPacient.Text = "Adauga pacient";
            this.menuAdaugaPacient.Click += new System.EventHandler(this.menuAdaugaPacient_Click);
            // 
            // dropDownPacienti
            // 
            this.dropDownPacienti.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropDownPacienti.Location = new System.Drawing.Point(397, 26);
            this.dropDownPacienti.Name = "dropDownPacienti";
            this.dropDownPacienti.NullText = "Pacient";
            this.dropDownPacienti.Size = new System.Drawing.Size(315, 20);
            this.dropDownPacienti.TabIndex = 2;
            // 
            // gridSpecialitati
            // 
            this.gridSpecialitati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.gridSpecialitati.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridSpecialitati.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridSpecialitati.ForeColor = System.Drawing.Color.Black;
            this.gridSpecialitati.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridSpecialitati.Location = new System.Drawing.Point(3, 26);
            // 
            // 
            // 
            this.gridSpecialitati.MasterTemplate.AllowAddNewRow = false;
            this.gridSpecialitati.MasterTemplate.AllowDeleteRow = false;
            this.gridSpecialitati.MasterTemplate.AllowSearchRow = true;
            this.gridSpecialitati.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn8.DataType = typeof(int);
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "SpecialitateId";
            gridViewDecimalColumn8.HeaderText = "SpecialitateId";
            gridViewDecimalColumn8.IsVisible = false;
            gridViewDecimalColumn8.Name = "SpecialitateId";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Nume";
            gridViewTextBoxColumn6.HeaderText = "Specialitate";
            gridViewTextBoxColumn6.Name = "Nume";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 310;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "Activa";
            gridViewCheckBoxColumn2.HeaderText = "Activa";
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "Activa";
            gridViewCheckBoxColumn2.Width = 58;
            this.gridSpecialitati.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn8,
            gridViewTextBoxColumn6,
            gridViewCheckBoxColumn2});
            this.gridSpecialitati.MasterTemplate.EnableFiltering = true;
            this.gridSpecialitati.MasterTemplate.EnableGrouping = false;
            this.gridSpecialitati.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.gridSpecialitati.Name = "gridSpecialitati";
            this.gridSpecialitati.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridSpecialitati.Size = new System.Drawing.Size(388, 464);
            this.gridSpecialitati.TabIndex = 1;
            this.gridSpecialitati.Text = "radGridView2";
            // 
            // wizardWelcomePage1
            // 
            this.wizardWelcomePage1.ContentArea = this.panel1;
            this.wizardWelcomePage1.Header = "Page header";
            this.wizardWelcomePage1.HeaderVisibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.wizardWelcomePage1.Name = "wizardWelcomePage1";
            this.wizardWelcomePage1.Title = "Adauga specialitati si selectare pacient";
            // 
            // FereastraAdaugaProgramare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 594);
            this.Controls.Add(this.radWizard1);
            this.Name = "FereastraAdaugaProgramare";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Adaugare programare serviciu medical";
            ((System.ComponentModel.ISupportInitialize)(this.radWizard1)).EndInit();
            this.radWizard1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProgramare.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProgramare)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownPacienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpecialitati.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpecialitati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadWizard radWizard1;
        private Telerik.WinControls.UI.WizardCompletionPage wizardCompletionPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.WizardWelcomePage wizardWelcomePage1;
        private Telerik.WinControls.UI.RadDropDownList dropDownPacienti;
        private Telerik.WinControls.UI.RadGridView gridSpecialitati;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menuAdaugaPacient;
        private Telerik.WinControls.UI.RadGridView gridProgramare;
    }
}

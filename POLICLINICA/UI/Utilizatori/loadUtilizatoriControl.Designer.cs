namespace POLICLINICA.UI
{
    partial class loadUtilizatoriControl
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
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn4 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn5 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn6 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn7 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn8 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn9 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn10 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.enumBinder1 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.enumBinder2 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.enumBinder3 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.enumBinder4 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.enumBinder5 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.gridViewUtilizatori = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUtilizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUtilizatori.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // enumBinder1
            // 
            this.enumBinder1.Source = typeof(Policlinica.Data.Enums.GradAsistentMedical);
            gridViewComboBoxColumn1.DataSource = this.enumBinder1;
            gridViewComboBoxColumn1.DataType = typeof(Policlinica.Data.Enums.GradAsistentMedical);
            gridViewComboBoxColumn1.DisplayMember = "Description";
            gridViewComboBoxColumn1.FieldName = "GradAsistent";
            gridViewComboBoxColumn1.HeaderText = "GradAsistent";
            gridViewComboBoxColumn1.IsAutoGenerated = true;
            gridViewComboBoxColumn1.Name = "GradAsistent";
            gridViewComboBoxColumn1.ValueMember = "Value";
            this.enumBinder1.Target = gridViewComboBoxColumn1;
            // 
            // enumBinder2
            // 
            this.enumBinder2.Source = typeof(Policlinica.Data.Enums.TipAsistentMedical);
            gridViewComboBoxColumn2.DataSource = this.enumBinder2;
            gridViewComboBoxColumn2.DataType = typeof(Policlinica.Data.Enums.TipAsistentMedical);
            gridViewComboBoxColumn2.DisplayMember = "Description";
            gridViewComboBoxColumn2.FieldName = "TipAsistent";
            gridViewComboBoxColumn2.HeaderText = "TipAsistent";
            gridViewComboBoxColumn2.IsAutoGenerated = true;
            gridViewComboBoxColumn2.Name = "TipAsistent";
            gridViewComboBoxColumn2.ValueMember = "Value";
            this.enumBinder2.Target = gridViewComboBoxColumn2;
            // 
            // enumBinder3
            // 
            this.enumBinder3.Source = typeof(Policlinica.Data.Enums.GradMedic);
            gridViewComboBoxColumn3.DataSource = this.enumBinder3;
            gridViewComboBoxColumn3.DataType = typeof(Policlinica.Data.Enums.GradMedic);
            gridViewComboBoxColumn3.DisplayMember = "Description";
            gridViewComboBoxColumn3.FieldName = "GradMedic";
            gridViewComboBoxColumn3.HeaderText = "GradMedic";
            gridViewComboBoxColumn3.IsAutoGenerated = true;
            gridViewComboBoxColumn3.Name = "GradMedic";
            gridViewComboBoxColumn3.ValueMember = "Value";
            this.enumBinder3.Target = gridViewComboBoxColumn3;
            // 
            // enumBinder4
            // 
            this.enumBinder4.Source = typeof(Policlinica.Data.Enums.TitluStiintific);
            gridViewComboBoxColumn4.DataSource = this.enumBinder4;
            gridViewComboBoxColumn4.DataType = typeof(Policlinica.Data.Enums.TitluStiintific);
            gridViewComboBoxColumn4.DisplayMember = "Description";
            gridViewComboBoxColumn4.FieldName = "TitlulStiintific";
            gridViewComboBoxColumn4.HeaderText = "TitlulStiintific";
            gridViewComboBoxColumn4.IsAutoGenerated = true;
            gridViewComboBoxColumn4.Name = "TitlulStiintific";
            gridViewComboBoxColumn4.ValueMember = "Value";
            this.enumBinder4.Target = gridViewComboBoxColumn4;
            // 
            // enumBinder5
            // 
            this.enumBinder5.Source = typeof(Policlinica.Data.Enums.PostDidactic);
            gridViewComboBoxColumn5.DataSource = this.enumBinder5;
            gridViewComboBoxColumn5.DataType = typeof(Policlinica.Data.Enums.PostDidactic);
            gridViewComboBoxColumn5.DisplayMember = "Description";
            gridViewComboBoxColumn5.FieldName = "PostulDidactic";
            gridViewComboBoxColumn5.HeaderText = "PostulDidactic";
            gridViewComboBoxColumn5.IsAutoGenerated = true;
            gridViewComboBoxColumn5.Name = "PostulDidactic";
            gridViewComboBoxColumn5.ValueMember = "Value";
            this.enumBinder5.Target = gridViewComboBoxColumn5;
            // 
            // gridViewUtilizatori
            // 
            this.gridViewUtilizatori.BackColor = System.Drawing.SystemColors.Control;
            this.gridViewUtilizatori.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewUtilizatori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewUtilizatori.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridViewUtilizatori.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridViewUtilizatori.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridViewUtilizatori.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridViewUtilizatori.MasterTemplate.AllowAddNewRow = false;
            this.gridViewUtilizatori.MasterTemplate.AllowDeleteRow = false;
            this.gridViewUtilizatori.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "UtilizatorId";
            gridViewDecimalColumn1.HeaderText = "UtilizatorId";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "UtilizatorId";
            gridViewDecimalColumn1.Width = 81;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "CNP";
            gridViewTextBoxColumn1.HeaderText = "CNP";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "CNP";
            gridViewTextBoxColumn1.Width = 87;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Nume";
            gridViewTextBoxColumn2.HeaderText = "Nume";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Nume";
            gridViewTextBoxColumn2.Width = 92;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Prenume";
            gridViewTextBoxColumn3.HeaderText = "Prenume";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Prenume";
            gridViewTextBoxColumn3.Width = 77;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Telefon";
            gridViewTextBoxColumn4.HeaderText = "Telefon";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Telefon";
            gridViewTextBoxColumn4.Width = 94;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Email";
            gridViewTextBoxColumn5.HeaderText = "Email";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Email";
            gridViewTextBoxColumn5.Width = 70;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "IBAN";
            gridViewTextBoxColumn6.HeaderText = "IBAN";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "IBAN";
            gridViewTextBoxColumn6.Width = 78;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "NumarContract";
            gridViewDecimalColumn2.HeaderText = "NumarContract";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "NumarContract";
            gridViewDecimalColumn2.Width = 95;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "DataAngajare";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.FormatString = "{0:dd/MM/yyyy}";
            gridViewDateTimeColumn1.HeaderText = "DataAngajare";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "DataAngajare";
            gridViewDateTimeColumn1.Width = 94;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Salar";
            gridViewDecimalColumn3.HeaderText = "Salar";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "Salar";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Adresa";
            gridViewTextBoxColumn7.HeaderText = "Adresa";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Adresa";
            gridViewTextBoxColumn7.Width = 77;
            gridViewComboBoxColumn6.DataSource = this.enumBinder1;
            gridViewComboBoxColumn6.DataType = typeof(object);
            gridViewComboBoxColumn6.DisplayMember = "Description";
            gridViewComboBoxColumn6.EnableExpressionEditor = false;
            gridViewComboBoxColumn6.FieldName = "GradAsistent";
            gridViewComboBoxColumn6.HeaderText = "GradAsistent";
            gridViewComboBoxColumn6.IsAutoGenerated = true;
            gridViewComboBoxColumn6.Name = "GradAsistent";
            gridViewComboBoxColumn6.ValueMember = "Value";
            gridViewComboBoxColumn6.Width = 105;
            gridViewComboBoxColumn7.DataSource = this.enumBinder2;
            gridViewComboBoxColumn7.DataType = typeof(object);
            gridViewComboBoxColumn7.DisplayMember = "Description";
            gridViewComboBoxColumn7.EnableExpressionEditor = false;
            gridViewComboBoxColumn7.FieldName = "TipAsistent";
            gridViewComboBoxColumn7.HeaderText = "TipAsistent";
            gridViewComboBoxColumn7.IsAutoGenerated = true;
            gridViewComboBoxColumn7.Name = "TipAsistent";
            gridViewComboBoxColumn7.ValueMember = "Value";
            gridViewComboBoxColumn7.Width = 98;
            gridViewComboBoxColumn8.DataSource = this.enumBinder3;
            gridViewComboBoxColumn8.DataType = typeof(object);
            gridViewComboBoxColumn8.DisplayMember = "Description";
            gridViewComboBoxColumn8.EnableExpressionEditor = false;
            gridViewComboBoxColumn8.FieldName = "GradMedic";
            gridViewComboBoxColumn8.HeaderText = "GradMedic";
            gridViewComboBoxColumn8.IsAutoGenerated = true;
            gridViewComboBoxColumn8.Name = "GradMedic";
            gridViewComboBoxColumn8.ValueMember = "Value";
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "CodulDeParafa";
            gridViewTextBoxColumn8.HeaderText = "CodulDeParafa";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "CodulDeParafa";
            gridViewTextBoxColumn8.Width = 103;
            gridViewComboBoxColumn9.DataSource = this.enumBinder4;
            gridViewComboBoxColumn9.DataType = typeof(object);
            gridViewComboBoxColumn9.DisplayMember = "Description";
            gridViewComboBoxColumn9.EnableExpressionEditor = false;
            gridViewComboBoxColumn9.FieldName = "TitlulStiintific";
            gridViewComboBoxColumn9.HeaderText = "TitlulStiintific";
            gridViewComboBoxColumn9.IsAutoGenerated = true;
            gridViewComboBoxColumn9.Name = "TitlulStiintific";
            gridViewComboBoxColumn9.ValueMember = "Value";
            gridViewComboBoxColumn9.Width = 101;
            gridViewComboBoxColumn10.DataSource = this.enumBinder5;
            gridViewComboBoxColumn10.DataType = typeof(object);
            gridViewComboBoxColumn10.DisplayMember = "Description";
            gridViewComboBoxColumn10.EnableExpressionEditor = false;
            gridViewComboBoxColumn10.FieldName = "PostulDidactic";
            gridViewComboBoxColumn10.HeaderText = "PostulDidactic";
            gridViewComboBoxColumn10.IsAutoGenerated = true;
            gridViewComboBoxColumn10.Name = "PostulDidactic";
            gridViewComboBoxColumn10.ValueMember = "Value";
            gridViewComboBoxColumn10.Width = 109;
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<decimal>);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "ProcentServicii";
            gridViewDecimalColumn4.HeaderText = "ProcentServicii";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "ProcentServicii";
            gridViewDecimalColumn4.Width = 79;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "Rol";
            gridViewTextBoxColumn9.HeaderText = "Rol";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "Rol";
            gridViewTextBoxColumn9.Width = 69;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Functie";
            gridViewTextBoxColumn10.HeaderText = "Functie";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "Functie";
            gridViewTextBoxColumn10.Width = 68;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "Departament";
            gridViewTextBoxColumn11.HeaderText = "Departament";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.Name = "Departament";
            gridViewTextBoxColumn11.Width = 85;
            this.gridViewUtilizatori.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn2,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn7,
            gridViewComboBoxColumn6,
            gridViewComboBoxColumn7,
            gridViewComboBoxColumn8,
            gridViewTextBoxColumn8,
            gridViewComboBoxColumn9,
            gridViewComboBoxColumn10,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.gridViewUtilizatori.MasterTemplate.EnableFiltering = true;
            this.gridViewUtilizatori.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridViewUtilizatori.Name = "gridViewUtilizatori";
            this.gridViewUtilizatori.ReadOnly = true;
            this.gridViewUtilizatori.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewUtilizatori.Size = new System.Drawing.Size(848, 515);
            this.gridViewUtilizatori.TabIndex = 0;
            // 
            // loadUtilizatoriControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridViewUtilizatori);
            this.Name = "loadUtilizatoriControl";
            this.Size = new System.Drawing.Size(848, 515);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUtilizatori.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUtilizatori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView gridViewUtilizatori;
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder1;
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder2;
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder3;
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder4;
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder5;
    }
}

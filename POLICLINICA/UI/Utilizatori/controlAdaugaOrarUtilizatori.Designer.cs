namespace POLICLINICA.UI
{
    partial class controlAdaugaOrarUtilizatori
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridViewOrar = new Telerik.WinControls.UI.RadGridView();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.menuButtonCO = new Telerik.WinControls.UI.RadMenuItem();
            this.menuButtonCM = new Telerik.WinControls.UI.RadMenuItem();
            this.menuButtonNemotivat = new Telerik.WinControls.UI.RadMenuItem();
            this.menuButtonAltProgram = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrar.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewOrar
            // 
            this.gridViewOrar.BackColor = System.Drawing.SystemColors.Control;
            this.gridViewOrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewOrar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridViewOrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridViewOrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridViewOrar.Location = new System.Drawing.Point(0, 30);
            // 
            // 
            // 
            this.gridViewOrar.MasterTemplate.AllowColumnChooser = false;
            this.gridViewOrar.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Zi";
            gridViewTextBoxColumn1.HeaderText = "Zi";
            gridViewTextBoxColumn1.Name = "Zi";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 77;
            gridViewDateTimeColumn1.EditorType = Telerik.WinControls.UI.GridViewDateTimeEditorType.TimePicker;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumTime;
            gridViewDateTimeColumn1.FieldName = "IncepereProgram";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            gridViewDateTimeColumn1.HeaderText = "Incepere program";
            gridViewDateTimeColumn1.Name = "IncepereProgram";
            gridViewDateTimeColumn1.Width = 98;
            gridViewDateTimeColumn1.WrapText = true;
            gridViewDateTimeColumn2.EditorType = Telerik.WinControls.UI.GridViewDateTimeEditorType.TimePicker;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumTime;
            gridViewDateTimeColumn2.FieldName = "SfarsitProgram";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            gridViewDateTimeColumn2.HeaderText = "Sfarsit program";
            gridViewDateTimeColumn2.Name = "SfarsitProgram";
            gridViewDateTimeColumn2.Width = 84;
            gridViewDateTimeColumn2.WrapText = true;
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "DataZiSpeciala";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn3.FormatString = "{0:dd/MM/yyyy}";
            gridViewDateTimeColumn3.HeaderText = "Zi speciala";
            gridViewDateTimeColumn3.Name = "DataZiSpeciala";
            gridViewDateTimeColumn3.Width = 107;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "OrarId";
            gridViewDecimalColumn1.HeaderText = "OrarId";
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "OrarId";
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Fk_UtilizatorId";
            gridViewDecimalColumn2.HeaderText = "Fk_UtilizatorId";
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "Fk_UtilizatorId";
            this.gridViewOrar.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDateTimeColumn3,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2});
            this.gridViewOrar.MasterTemplate.EnableGrouping = false;
            this.gridViewOrar.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridViewOrar.Name = "gridViewOrar";
            this.gridViewOrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewOrar.Size = new System.Drawing.Size(425, 421);
            this.gridViewOrar.TabIndex = 0;
            this.gridViewOrar.Text = "radGridView1";
            this.gridViewOrar.EditorRequired += new Telerik.WinControls.UI.EditorRequiredEventHandler(this.MasterTemplate_EditorRequired);
            this.gridViewOrar.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.MasterTemplate_UserDeletingRow);
            this.gridViewOrar.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MasterTemplate_CellValueChanged);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuButtonCO,
            this.menuButtonCM,
            this.menuButtonNemotivat,
            this.menuButtonAltProgram});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(507, 20);
            this.radMenu1.TabIndex = 1;
            this.radMenu1.Text = "radMenu1";
            // 
            // menuButtonCO
            // 
            this.menuButtonCO.Name = "menuButtonCO";
            this.menuButtonCO.Text = "Aplica CO";
            this.menuButtonCO.Click += new System.EventHandler(this.menuButtonCO_Click);
            // 
            // menuButtonCM
            // 
            this.menuButtonCM.Name = "menuButtonCM";
            this.menuButtonCM.Text = "Aplica CM";
            this.menuButtonCM.Click += new System.EventHandler(this.menuButtonCM_Click);
            // 
            // menuButtonNemotivat
            // 
            this.menuButtonNemotivat.Name = "menuButtonNemotivat";
            this.menuButtonNemotivat.Text = "Aplica Nemotivat";
            this.menuButtonNemotivat.Click += new System.EventHandler(this.menuButtonNemotivat_Click);
            // 
            // menuButtonAltProgram
            // 
            this.menuButtonAltProgram.Name = "menuButtonAltProgram";
            this.menuButtonAltProgram.Text = "Alt program";
            this.menuButtonAltProgram.Click += new System.EventHandler(this.menuButtonAltProgram_Click);
            // 
            // controlAdaugaOrarUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.gridViewOrar);
            this.Name = "controlAdaugaOrarUtilizatori";
            this.Size = new System.Drawing.Size(507, 454);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrar.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridViewOrar;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menuButtonCO;
        private Telerik.WinControls.UI.RadMenuItem menuButtonCM;
        private Telerik.WinControls.UI.RadMenuItem menuButtonNemotivat;
        private Telerik.WinControls.UI.RadMenuItem menuButtonAltProgram;
    }
}

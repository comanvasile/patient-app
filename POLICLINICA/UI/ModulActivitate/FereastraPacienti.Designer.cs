namespace POLICLINICA.UI
{
    partial class FereastraPacienti
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.gridPacienti = new Telerik.WinControls.UI.RadGridView();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup1 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.buttonIesire = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.buttonAdauga = new Telerik.WinControls.UI.RadButtonElement();
            this.buttonModifica = new Telerik.WinControls.UI.RadButtonElement();
            this.buttonIstoricPacient = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacienti.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.Size = new System.Drawing.Size(699, 162);
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "Pacienti";
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // gridPacienti
            // 
            this.gridPacienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gridPacienti.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPacienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPacienti.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridPacienti.ForeColor = System.Drawing.Color.Black;
            this.gridPacienti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridPacienti.Location = new System.Drawing.Point(0, 162);
            // 
            // 
            // 
            this.gridPacienti.MasterTemplate.AllowAddNewRow = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "PacientId";
            gridViewDecimalColumn1.HeaderText = "PacientId";
            gridViewDecimalColumn1.Name = "PacientId";
            gridViewDecimalColumn1.Width = 61;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Nume";
            gridViewTextBoxColumn1.HeaderText = "Nume";
            gridViewTextBoxColumn1.Name = "Nume";
            gridViewTextBoxColumn1.Width = 86;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Prenume";
            gridViewTextBoxColumn2.HeaderText = "Prenume";
            gridViewTextBoxColumn2.Name = "Prenume";
            gridViewTextBoxColumn2.Width = 89;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "CNP";
            gridViewTextBoxColumn3.HeaderText = "CNP";
            gridViewTextBoxColumn3.Name = "CNP";
            gridViewTextBoxColumn3.Width = 114;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "CardSanatate";
            gridViewTextBoxColumn4.HeaderText = "CardSanatate";
            gridViewTextBoxColumn4.Name = "CardSanatate";
            gridViewTextBoxColumn4.Width = 108;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Ocupatie";
            gridViewTextBoxColumn5.HeaderText = "Ocupatie";
            gridViewTextBoxColumn5.Name = "Ocupatie";
            gridViewTextBoxColumn5.Width = 121;
            this.gridPacienti.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.gridPacienti.MasterTemplate.EnableFiltering = true;
            this.gridPacienti.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridPacienti.Name = "gridPacienti";
            this.gridPacienti.ReadOnly = true;
            this.gridPacienti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridPacienti.Size = new System.Drawing.Size(699, 424);
            this.gridPacienti.TabIndex = 0;
            this.gridPacienti.Text = "radGridView1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Pacienti";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup1});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Actiuni";
            // 
            // radRibbonBarButtonGroup1
            // 
            this.radRibbonBarButtonGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.buttonIesire});
            this.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1";
            // 
            // buttonIesire
            // 
            this.buttonIesire.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.buttonIesire.MinSize = new System.Drawing.Size(60, 0);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Text = "Iesire";
            this.buttonIesire.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIesire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup2});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "Operatii";
            // 
            // radRibbonBarButtonGroup2
            // 
            this.radRibbonBarButtonGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.buttonAdauga,
            this.buttonModifica,
            this.buttonIstoricPacient});
            this.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2";
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdauga.MinSize = new System.Drawing.Size(60, 0);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdauga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.buttonModifica.MinSize = new System.Drawing.Size(60, 0);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // buttonIstoricPacient
            // 
            this.buttonIstoricPacient.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.buttonIstoricPacient.MaxSize = new System.Drawing.Size(70, 0);
            this.buttonIstoricPacient.MinSize = new System.Drawing.Size(60, 0);
            this.buttonIstoricPacient.Name = "buttonIstoricPacient";
            this.buttonIstoricPacient.Text = "Istoric pacient";
            this.buttonIstoricPacient.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIstoricPacient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonIstoricPacient.TextWrap = true;
            this.buttonIstoricPacient.Click += new System.EventHandler(this.buttonIstoricPacient_Click);
            // 
            // FereastraPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 586);
            this.Controls.Add(this.gridPacienti);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "FereastraPacienti";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Pacienti";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacienti.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup1;
        private Telerik.WinControls.UI.RadButtonElement buttonIesire;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup2;
        private Telerik.WinControls.UI.RadButtonElement buttonAdauga;
        private Telerik.WinControls.UI.RadButtonElement buttonModifica;
        private Telerik.WinControls.UI.RadGridView gridPacienti;
        private Telerik.WinControls.UI.RadButtonElement buttonIstoricPacient;
    }
}

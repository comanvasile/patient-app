namespace POLICLINICA.UI
{
    partial class FereastraAngajati
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
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup1 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.buttonIesire = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.buttonAdauga = new Telerik.WinControls.UI.RadButtonElement();
            this.buttonModifica = new Telerik.WinControls.UI.RadButtonElement();
            this.buttonSterge = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup3 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.buttonOrar = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.loadUtilizatoriControl1 = new POLICLINICA.UI.loadUtilizatoriControl();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
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
            this.radRibbonBar1.Size = new System.Drawing.Size(861, 162);
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "HR | Angajati";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Angajati";
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
            this.radRibbonBarGroup2.Text = "Operratii";
            // 
            // radRibbonBarButtonGroup2
            // 
            this.radRibbonBarButtonGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.buttonAdauga,
            this.buttonModifica,
            this.buttonSterge});
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
            // buttonSterge
            // 
            this.buttonSterge.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSterge.MinSize = new System.Drawing.Size(60, 0);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSterge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup3});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "Program";
            // 
            // radRibbonBarButtonGroup3
            // 
            this.radRibbonBarButtonGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.buttonOrar});
            this.radRibbonBarButtonGroup3.Name = "radRibbonBarButtonGroup3";
            this.radRibbonBarButtonGroup3.Text = "radRibbonBarButtonGroup3";
            // 
            // buttonOrar
            // 
            this.buttonOrar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOrar.MinSize = new System.Drawing.Size(60, 0);
            this.buttonOrar.Name = "buttonOrar";
            this.buttonOrar.Text = "Orar";
            this.buttonOrar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOrar.Click += new System.EventHandler(this.buttonOrar_Click);
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // loadUtilizatoriControl1
            // 
            this.loadUtilizatoriControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadUtilizatoriControl1.Location = new System.Drawing.Point(0, 162);
            this.loadUtilizatoriControl1.Name = "loadUtilizatoriControl1";
            this.loadUtilizatoriControl1.Size = new System.Drawing.Size(861, 672);
            this.loadUtilizatoriControl1.TabIndex = 1;
            // 
            // FereastraAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 872);
            this.Controls.Add(this.loadUtilizatoriControl1);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "FereastraAngajati";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "HR | Angajati";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup1;
        private Telerik.WinControls.UI.RadButtonElement buttonIesire;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup2;
        private Telerik.WinControls.UI.RadButtonElement buttonAdauga;
        private Telerik.WinControls.UI.RadButtonElement buttonModifica;
        private Telerik.WinControls.UI.RadButtonElement buttonSterge;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup3;
        private Telerik.WinControls.UI.RadButtonElement buttonOrar;
        private loadUtilizatoriControl loadUtilizatoriControl1;
    }
}

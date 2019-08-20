namespace POLICLINICA.UI
{
    partial class FereastraAdaugaPacienti
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
            this.buttonSalvare = new Telerik.WinControls.UI.RadButtonElement();
            this.buttonRenunta = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.textBoxNume = new Telerik.WinControls.UI.RadTextBox();
            this.textBoxPrenume = new Telerik.WinControls.UI.RadTextBox();
            this.textBoxCNP = new Telerik.WinControls.UI.RadTextBox();
            this.textBoxCardSanatate = new Telerik.WinControls.UI.RadTextBox();
            this.textBoxOcupatie = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrenume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCardSanatate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOcupatie)).BeginInit();
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
            this.radRibbonBar1.Size = new System.Drawing.Size(380, 162);
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "Adaugare pacient";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Pacient";
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
            this.buttonSalvare,
            this.buttonRenunta});
            this.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1";
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalvare.MinSize = new System.Drawing.Size(60, 0);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Text = "Salvare";
            this.buttonSalvare.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRenunta.MinSize = new System.Drawing.Size(60, 0);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRenunta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(62, 189);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Nume:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(48, 215);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(53, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Prenume:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(71, 241);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(30, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "CNP:";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(24, 267);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(77, 18);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "Card sanatate:";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(47, 293);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(54, 18);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Ocupatie:";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(107, 188);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(241, 20);
            this.textBoxNume.TabIndex = 5;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(107, 214);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(241, 20);
            this.textBoxPrenume.TabIndex = 6;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(107, 240);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(241, 20);
            this.textBoxCNP.TabIndex = 7;
            this.textBoxCNP.Validated += new System.EventHandler(this.textBoxCNP_Validated);
            // 
            // textBoxCardSanatate
            // 
            this.textBoxCardSanatate.Location = new System.Drawing.Point(107, 266);
            this.textBoxCardSanatate.Name = "textBoxCardSanatate";
            this.textBoxCardSanatate.Size = new System.Drawing.Size(241, 20);
            this.textBoxCardSanatate.TabIndex = 8;
            // 
            // textBoxOcupatie
            // 
            this.textBoxOcupatie.Location = new System.Drawing.Point(107, 292);
            this.textBoxOcupatie.Name = "textBoxOcupatie";
            this.textBoxOcupatie.Size = new System.Drawing.Size(241, 20);
            this.textBoxOcupatie.TabIndex = 9;
            // 
            // FereastraAdaugaPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 401);
            this.Controls.Add(this.textBoxOcupatie);
            this.Controls.Add(this.textBoxCardSanatate);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "FereastraAdaugaPacienti";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Adaugare pacient";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrenume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCardSanatate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOcupatie)).EndInit();
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
        private Telerik.WinControls.UI.RadButtonElement buttonSalvare;
        private Telerik.WinControls.UI.RadButtonElement buttonRenunta;
        private Telerik.WinControls.UI.RadTextBox textBoxOcupatie;
        private Telerik.WinControls.UI.RadTextBox textBoxCardSanatate;
        private Telerik.WinControls.UI.RadTextBox textBoxCNP;
        private Telerik.WinControls.UI.RadTextBox textBoxPrenume;
        private Telerik.WinControls.UI.RadTextBox textBoxNume;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}

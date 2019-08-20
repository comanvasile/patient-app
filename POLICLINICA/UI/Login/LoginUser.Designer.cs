namespace POLICLINICA.UI
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            this.labelUtilizator = new Telerik.WinControls.UI.RadLabel();
            this.labelParola = new Telerik.WinControls.UI.RadLabel();
            this.textBoxUtilizator = new Telerik.WinControls.UI.RadTextBox();
            this.textBoxParola = new Telerik.WinControls.UI.RadTextBox();
            this.buttonOk = new Telerik.WinControls.UI.RadButton();
            this.buttonAnulare = new Telerik.WinControls.UI.RadButton();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.labelUtilizator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelParola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUtilizator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxParola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAnulare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUtilizator
            // 
            this.labelUtilizator.Location = new System.Drawing.Point(12, 18);
            this.labelUtilizator.Name = "labelUtilizator";
            this.labelUtilizator.Size = new System.Drawing.Size(54, 18);
            this.labelUtilizator.TabIndex = 0;
            this.labelUtilizator.Text = "Utilizator:";
            // 
            // labelParola
            // 
            this.labelParola.Location = new System.Drawing.Point(26, 44);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(40, 18);
            this.labelParola.TabIndex = 1;
            this.labelParola.Text = "Parola:";
            // 
            // textBoxUtilizator
            // 
            this.textBoxUtilizator.Location = new System.Drawing.Point(88, 16);
            this.textBoxUtilizator.Name = "textBoxUtilizator";
            this.textBoxUtilizator.Size = new System.Drawing.Size(162, 20);
            this.textBoxUtilizator.TabIndex = 2;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(88, 42);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(162, 20);
            this.textBoxParola.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(88, 68);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(77, 24);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnulare
            // 
            this.buttonAnulare.Location = new System.Drawing.Point(171, 68);
            this.buttonAnulare.Name = "buttonAnulare";
            this.buttonAnulare.Size = new System.Drawing.Size(77, 24);
            this.buttonAnulare.TabIndex = 5;
            this.buttonAnulare.Text = "Anulare";
            this.buttonAnulare.Click += new System.EventHandler(this.buttonAnulare_Click);
            // 
            // LoginUser
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 103);
            this.Controls.Add(this.buttonAnulare);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxUtilizator);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelUtilizator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginUser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Policlinica";
            ((System.ComponentModel.ISupportInitialize)(this.labelUtilizator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelParola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUtilizator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxParola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAnulare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel labelUtilizator;
        private Telerik.WinControls.UI.RadLabel labelParola;
        private Telerik.WinControls.UI.RadTextBox textBoxUtilizator;
        private Telerik.WinControls.UI.RadTextBox textBoxParola;
        private Telerik.WinControls.UI.RadButton buttonOk;
        private Telerik.WinControls.UI.RadButton buttonAnulare;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
    }
}

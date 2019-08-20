namespace POLICLINICA.UI
{
    partial class VizualizareProfit
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
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn4 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            this.enumBinder1 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.enumBinder2 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup1 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.buttonIesire = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.dropDownUnitate = new Telerik.WinControls.UI.RadDropDownListElement();
            this.radRibbonBarButtonGroup3 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.dropDownLuna = new Telerik.WinControls.UI.RadDropDownListElement();
            this.dropDownAn = new Telerik.WinControls.UI.RadDropDownListElement();
            this.radRibbonBarButtonGroup4 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.buttonReincarcaDate = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.toolWindowRaport = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.gridRaport = new Telerik.WinControls.UI.RadGridView();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.windowVenituri = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.gridVenituri = new Telerik.WinControls.UI.RadGridView();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip2 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.windowCheltuieli = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.gridCheltuieli = new Telerik.WinControls.UI.RadGridView();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownUnitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            this.toolWindowRaport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRaport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRaport.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            this.windowVenituri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenituri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenituri.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip2)).BeginInit();
            this.documentTabStrip2.SuspendLayout();
            this.windowCheltuieli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheltuieli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheltuieli.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // enumBinder1
            // 
            this.enumBinder1.Source = typeof(Policlinica.Data.Enums.GradMedic);
            gridViewComboBoxColumn3.DataSource = this.enumBinder1;
            gridViewComboBoxColumn3.DataType = typeof(int);
            gridViewComboBoxColumn3.DisplayMember = "Description";
            gridViewComboBoxColumn3.FieldName = "Grad";
            gridViewComboBoxColumn3.HeaderText = "Grad";
            gridViewComboBoxColumn3.IsAutoGenerated = true;
            gridViewComboBoxColumn3.Name = "Grad";
            gridViewComboBoxColumn3.ValueMember = "Value";
            gridViewComboBoxColumn3.Width = 74;
            this.enumBinder1.Target = gridViewComboBoxColumn3;
            // 
            // enumBinder2
            // 
            this.enumBinder2.Source = typeof(Policlinica.Data.Enums.PostDidactic);
            gridViewComboBoxColumn4.DataSource = this.enumBinder2;
            gridViewComboBoxColumn4.DataType = typeof(System.Nullable<int>);
            gridViewComboBoxColumn4.DisplayMember = "Description";
            gridViewComboBoxColumn4.FieldName = "PostulDidactic";
            gridViewComboBoxColumn4.HeaderText = "PostulDidactic";
            gridViewComboBoxColumn4.IsAutoGenerated = true;
            gridViewComboBoxColumn4.Name = "PostulDidactic";
            gridViewComboBoxColumn4.ValueMember = "Value";
            gridViewComboBoxColumn4.Width = 74;
            this.enumBinder2.Target = gridViewComboBoxColumn4;
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
            this.radRibbonBar1.Size = new System.Drawing.Size(1089, 162);
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "radRibbonBar1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Contabilitate";
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
            this.buttonIesire.MaxSize = new System.Drawing.Size(0, 0);
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
            this.radRibbonBarButtonGroup2,
            this.radRibbonBarButtonGroup3,
            this.radRibbonBarButtonGroup4});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "Filtre";
            // 
            // radRibbonBarButtonGroup2
            // 
            this.radRibbonBarButtonGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.dropDownUnitate});
            this.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2";
            // 
            // dropDownUnitate
            // 
            this.dropDownUnitate.ArrowButtonMinWidth = 17;
            this.dropDownUnitate.AutoCompleteDataSource = null;
            this.dropDownUnitate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropDownUnitate.DataMember = "";
            this.dropDownUnitate.DataSource = null;
            this.dropDownUnitate.DefaultValue = null;
            this.dropDownUnitate.DisplayMember = "";
            this.dropDownUnitate.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad;
            this.dropDownUnitate.DropDownAnimationEnabled = true;
            this.dropDownUnitate.EditableElementText = "";
            this.dropDownUnitate.EditorElement = this.dropDownUnitate;
            this.dropDownUnitate.EditorManager = null;
            this.dropDownUnitate.Filter = null;
            this.dropDownUnitate.FilterExpression = "";
            this.dropDownUnitate.Focusable = true;
            this.dropDownUnitate.FormatString = "";
            this.dropDownUnitate.FormattingEnabled = true;
            this.dropDownUnitate.ItemHeight = 18;
            this.dropDownUnitate.MaxDropDownItems = 0;
            this.dropDownUnitate.MaxLength = 32767;
            this.dropDownUnitate.MaxValue = null;
            this.dropDownUnitate.MinValue = null;
            this.dropDownUnitate.Name = "dropDownUnitate";
            this.dropDownUnitate.NullValue = null;
            this.dropDownUnitate.OwnerOffset = 0;
            this.dropDownUnitate.ShowImageInEditorArea = true;
            this.dropDownUnitate.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None;
            this.dropDownUnitate.Value = null;
            this.dropDownUnitate.ValueMember = "";
            // 
            // radRibbonBarButtonGroup3
            // 
            this.radRibbonBarButtonGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.dropDownLuna,
            this.dropDownAn});
            this.radRibbonBarButtonGroup3.Name = "radRibbonBarButtonGroup3";
            this.radRibbonBarButtonGroup3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarButtonGroup3.Text = "radRibbonBarButtonGroup3";
            // 
            // dropDownLuna
            // 
            this.dropDownLuna.ArrowButtonMinWidth = 17;
            this.dropDownLuna.AutoCompleteDataSource = null;
            this.dropDownLuna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropDownLuna.DataMember = "";
            this.dropDownLuna.DataSource = null;
            this.dropDownLuna.DefaultValue = null;
            this.dropDownLuna.DisplayMember = "";
            this.dropDownLuna.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad;
            this.dropDownLuna.DropDownAnimationEnabled = true;
            this.dropDownLuna.EditableElementText = "";
            this.dropDownLuna.EditorElement = this.dropDownLuna;
            this.dropDownLuna.EditorManager = null;
            this.dropDownLuna.Filter = null;
            this.dropDownLuna.FilterExpression = "";
            this.dropDownLuna.Focusable = true;
            this.dropDownLuna.FormatString = "";
            this.dropDownLuna.FormattingEnabled = true;
            this.dropDownLuna.ItemHeight = 18;
            this.dropDownLuna.MaxDropDownItems = 0;
            this.dropDownLuna.MaxLength = 32767;
            this.dropDownLuna.MaxValue = null;
            this.dropDownLuna.MinValue = null;
            this.dropDownLuna.Name = "dropDownLuna";
            this.dropDownLuna.NullValue = null;
            this.dropDownLuna.OwnerOffset = 0;
            this.dropDownLuna.ShowImageInEditorArea = true;
            this.dropDownLuna.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None;
            this.dropDownLuna.Value = null;
            this.dropDownLuna.ValueMember = "";
            // 
            // dropDownAn
            // 
            this.dropDownAn.ArrowButtonMinWidth = 17;
            this.dropDownAn.AutoCompleteDataSource = null;
            this.dropDownAn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropDownAn.DataMember = "";
            this.dropDownAn.DataSource = null;
            this.dropDownAn.DefaultValue = null;
            this.dropDownAn.DisplayMember = "";
            this.dropDownAn.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad;
            this.dropDownAn.DropDownAnimationEnabled = true;
            this.dropDownAn.EditableElementText = "";
            this.dropDownAn.EditorElement = this.dropDownAn;
            this.dropDownAn.EditorManager = null;
            this.dropDownAn.Filter = null;
            this.dropDownAn.FilterExpression = "";
            this.dropDownAn.Focusable = true;
            this.dropDownAn.FormatString = "";
            this.dropDownAn.FormattingEnabled = true;
            this.dropDownAn.ItemHeight = 18;
            this.dropDownAn.MaxDropDownItems = 0;
            this.dropDownAn.MaxLength = 32767;
            this.dropDownAn.MaxValue = null;
            this.dropDownAn.MinValue = null;
            this.dropDownAn.Name = "dropDownAn";
            this.dropDownAn.NullValue = null;
            this.dropDownAn.OwnerOffset = 0;
            this.dropDownAn.ShowImageInEditorArea = true;
            this.dropDownAn.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None;
            this.dropDownAn.Value = null;
            this.dropDownAn.ValueMember = "";
            // 
            // radRibbonBarButtonGroup4
            // 
            this.radRibbonBarButtonGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.buttonReincarcaDate});
            this.radRibbonBarButtonGroup4.Name = "radRibbonBarButtonGroup4";
            this.radRibbonBarButtonGroup4.Text = "radRibbonBarButtonGroup4";
            // 
            // buttonReincarcaDate
            // 
            this.buttonReincarcaDate.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.buttonReincarcaDate.MaxSize = new System.Drawing.Size(70, 0);
            this.buttonReincarcaDate.MinSize = new System.Drawing.Size(60, 0);
            this.buttonReincarcaDate.Name = "buttonReincarcaDate";
            this.buttonReincarcaDate.Text = "Reincarca date";
            this.buttonReincarcaDate.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReincarcaDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReincarcaDate.TextWrap = true;
            this.buttonReincarcaDate.Click += new System.EventHandler(this.buttonReincarcaDate_Click);
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.toolWindowRaport;
            this.radDock1.CausesValidation = false;
            this.radDock1.Controls.Add(this.radSplitContainer1);
            this.radDock1.Controls.Add(this.toolTabStrip1);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 162);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radDock1.Size = new System.Drawing.Size(1089, 613);
            this.radDock1.TabIndex = 0;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // toolWindowRaport
            // 
            this.toolWindowRaport.Caption = null;
            this.toolWindowRaport.Controls.Add(this.gridRaport);
            this.toolWindowRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.toolWindowRaport.Location = new System.Drawing.Point(1, 24);
            this.toolWindowRaport.Name = "toolWindowRaport";
            this.toolWindowRaport.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.toolWindowRaport.Size = new System.Drawing.Size(242, 577);
            this.toolWindowRaport.Text = "Raport venit | cheltuieli";
            // 
            // gridRaport
            // 
            this.gridRaport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRaport.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridRaport.MasterTemplate.AllowAddNewRow = false;
            this.gridRaport.MasterTemplate.AllowDeleteRow = false;
            this.gridRaport.MasterTemplate.AllowSearchRow = true;
            this.gridRaport.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridRaport.MasterTemplate.EnableFiltering = true;
            this.gridRaport.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.gridRaport.Name = "gridRaport";
            this.gridRaport.ReadOnly = true;
            this.gridRaport.Size = new System.Drawing.Size(242, 577);
            this.gridRaport.TabIndex = 1;
            this.gridRaport.Text = "radGridView3";
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.documentTabStrip1);
            this.radSplitContainer1.Controls.Add(this.documentContainer1);
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(5, 5);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radSplitContainer1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radSplitContainer1.Size = new System.Drawing.Size(831, 603);
            this.radSplitContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(815, 200);
            this.radSplitContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-44, 0);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.Controls.Add(this.windowVenituri);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(831, 283);
            this.documentTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 283);
            this.documentTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 83);
            this.documentTabStrip1.TabIndex = 1;
            this.documentTabStrip1.TabStop = false;
            // 
            // windowVenituri
            // 
            this.windowVenituri.Controls.Add(this.gridVenituri);
            this.windowVenituri.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            this.windowVenituri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.windowVenituri.Location = new System.Drawing.Point(6, 29);
            this.windowVenituri.Name = "windowVenituri";
            this.windowVenituri.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.windowVenituri.Size = new System.Drawing.Size(819, 248);
            this.windowVenituri.Text = "Venituri";
            // 
            // gridVenituri
            // 
            this.gridVenituri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVenituri.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridVenituri.MasterTemplate.AllowAddNewRow = false;
            this.gridVenituri.MasterTemplate.AllowDeleteRow = false;
            this.gridVenituri.MasterTemplate.AllowSearchRow = true;
            this.gridVenituri.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridVenituri.MasterTemplate.EnableFiltering = true;
            this.gridVenituri.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.gridVenituri.Name = "gridVenituri";
            this.gridVenituri.ReadOnly = true;
            this.gridVenituri.Size = new System.Drawing.Size(819, 248);
            this.gridVenituri.TabIndex = 2;
            this.gridVenituri.Text = "radGridView2";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip2);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 250);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -37);
            this.documentContainer1.TabIndex = 2;
            // 
            // documentTabStrip2
            // 
            this.documentTabStrip2.CanUpdateChildIndex = true;
            this.documentTabStrip2.Controls.Add(this.windowCheltuieli);
            this.documentTabStrip2.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip2.Name = "documentTabStrip2";
            // 
            // 
            // 
            this.documentTabStrip2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentTabStrip2.SelectedIndex = 0;
            this.documentTabStrip2.Size = new System.Drawing.Size(831, 316);
            this.documentTabStrip2.TabIndex = 0;
            this.documentTabStrip2.TabStop = false;
            // 
            // windowCheltuieli
            // 
            this.windowCheltuieli.Controls.Add(this.gridCheltuieli);
            this.windowCheltuieli.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            this.windowCheltuieli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.windowCheltuieli.Location = new System.Drawing.Point(6, 29);
            this.windowCheltuieli.Name = "windowCheltuieli";
            this.windowCheltuieli.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.windowCheltuieli.Size = new System.Drawing.Size(819, 281);
            this.windowCheltuieli.Text = "Cheltuieli";
            // 
            // gridCheltuieli
            // 
            this.gridCheltuieli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCheltuieli.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridCheltuieli.MasterTemplate.AllowAddNewRow = false;
            this.gridCheltuieli.MasterTemplate.AllowDeleteRow = false;
            this.gridCheltuieli.MasterTemplate.AllowSearchRow = true;
            this.gridCheltuieli.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridCheltuieli.MasterTemplate.EnableFiltering = true;
            this.gridCheltuieli.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.gridCheltuieli.Name = "gridCheltuieli";
            this.gridCheltuieli.ReadOnly = true;
            this.gridCheltuieli.Size = new System.Drawing.Size(819, 281);
            this.gridCheltuieli.TabIndex = 1;
            this.gridCheltuieli.Text = "radGridView2";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.CausesValidation = false;
            this.toolTabStrip1.Controls.Add(this.toolWindowRaport);
            this.toolTabStrip1.Location = new System.Drawing.Point(840, 5);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(244, 603);
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(244, 200);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(44, 0);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            // 
            // VizualizareProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 775);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "VizualizareProfit";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "radRibbonBar1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownUnitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            this.toolWindowRaport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRaport.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRaport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            this.windowVenituri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVenituri.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenituri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip2)).EndInit();
            this.documentTabStrip2.ResumeLayout(false);
            this.windowCheltuieli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheltuieli.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheltuieli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup1;
        private Telerik.WinControls.UI.RadButtonElement buttonIesire;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup2;
        private Telerik.WinControls.UI.RadDropDownListElement dropDownUnitate;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup3;
        private Telerik.WinControls.UI.RadDropDownListElement dropDownLuna;
        private Telerik.WinControls.UI.RadDropDownListElement dropDownAn;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindowRaport;
        private Telerik.WinControls.UI.RadGridView gridRaport;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow windowVenituri;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip2;
        private Telerik.WinControls.UI.Docking.DocumentWindow windowCheltuieli;
        private Telerik.WinControls.UI.RadGridView gridCheltuieli;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup4;
        private Telerik.WinControls.UI.RadButtonElement buttonReincarcaDate;
        private Telerik.WinControls.UI.RadGridView gridVenituri;
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder1;
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder2;
    }
}

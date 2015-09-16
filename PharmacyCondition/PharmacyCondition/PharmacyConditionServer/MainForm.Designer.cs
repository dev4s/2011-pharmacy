namespace PharmacyConditionServer
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dataGridViewGood = new System.Windows.Forms.DataGridView();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductDirtyBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductCleanBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductLongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductTypeOfBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductQuantityFromDatabase = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductQuantityStableFromDatabase = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductClientAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductClientModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductAddedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductModificationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.saveFileExportDialog = new System.Windows.Forms.SaveFileDialog();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonPreferences = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
			this.listBoxServerLog = new System.Windows.Forms.ListBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageMain = new System.Windows.Forms.TabPage();
			this.tabPageNotMain = new System.Windows.Forms.TabPage();
			this.dataGridViewBad = new System.Windows.Forms.DataGridView();
			this.NotProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NotProductDirtyBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NotProductCleanBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NotProductBarcodeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NotProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NotProductInsertedInto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NotProductClientAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NotProductClientModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NotProductDateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NotProductDateConnected = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageClients = new System.Windows.Forms.TabPage();
			this.buttonDisconnectAllClients = new System.Windows.Forms.Button();
			this.buttonDisconnectSelectedClient = new System.Windows.Forms.Button();
			this.listBoxConnectedClients = new System.Windows.Forms.ListBox();
			this.tabPageHistory = new System.Windows.Forms.TabPage();
			this.buttonDeleteAllHistorySessions = new System.Windows.Forms.Button();
			this.buttonDeleteSelectedHistorySession = new System.Windows.Forms.Button();
			this.buttonReadSelectedHistorySession = new System.Windows.Forms.Button();
			this.listBoxSessionHistory = new System.Windows.Forms.ListBox();
			this.tabPageLog = new System.Windows.Forms.TabPage();
			this.buttonLogClean = new System.Windows.Forms.Button();
			this.buttonLogSave = new System.Windows.Forms.Button();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).BeginInit();
			this.toolStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageMain.SuspendLayout();
			this.tabPageNotMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBad)).BeginInit();
			this.tabPageClients.SuspendLayout();
			this.tabPageHistory.SuspendLayout();
			this.tabPageLog.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewGood
			// 
			this.dataGridViewGood.AllowUserToAddRows = false;
			this.dataGridViewGood.AllowUserToDeleteRows = false;
			this.dataGridViewGood.AllowUserToResizeRows = false;
			this.dataGridViewGood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewGood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewGood.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewGood.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dataGridViewGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductDirtyBarcode,
            this.ProductCleanBarcode,
            this.ProductLongName,
            this.ProductTypeOfBarcode,
            this.ProductCount,
            this.ProductQuantityFromDatabase,
            this.ProductQuantityStableFromDatabase,
            this.ProductClientAdded,
            this.ProductClientModified,
            this.ProductAddedDate,
            this.ProductModificationDate});
			this.dataGridViewGood.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridViewGood.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewGood.MultiSelect = false;
			this.dataGridViewGood.Name = "dataGridViewGood";
			this.dataGridViewGood.ReadOnly = true;
			this.dataGridViewGood.RowHeadersVisible = false;
			this.dataGridViewGood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewGood.Size = new System.Drawing.Size(834, 336);
			this.dataGridViewGood.TabIndex = 0;
			// 
			// ProductID
			// 
			this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ProductID.HeaderText = "ID";
			this.ProductID.Name = "ProductID";
			this.ProductID.ReadOnly = true;
			this.ProductID.Visible = false;
			this.ProductID.Width = 79;
			// 
			// ProductDirtyBarcode
			// 
			this.ProductDirtyBarcode.HeaderText = "Kod kreskowy (brudny)";
			this.ProductDirtyBarcode.Name = "ProductDirtyBarcode";
			this.ProductDirtyBarcode.ReadOnly = true;
			this.ProductDirtyBarcode.Visible = false;
			// 
			// ProductCleanBarcode
			// 
			this.ProductCleanBarcode.HeaderText = "Kod kreskowy";
			this.ProductCleanBarcode.Name = "ProductCleanBarcode";
			this.ProductCleanBarcode.ReadOnly = true;
			// 
			// ProductLongName
			// 
			this.ProductLongName.HeaderText = "Nazwa";
			this.ProductLongName.Name = "ProductLongName";
			this.ProductLongName.ReadOnly = true;
			// 
			// ProductTypeOfBarcode
			// 
			this.ProductTypeOfBarcode.HeaderText = "Typ kodu kreskowego";
			this.ProductTypeOfBarcode.Name = "ProductTypeOfBarcode";
			this.ProductTypeOfBarcode.ReadOnly = true;
			// 
			// ProductCount
			// 
			this.ProductCount.HeaderText = "Zliczony stan";
			this.ProductCount.Name = "ProductCount";
			this.ProductCount.ReadOnly = true;
			// 
			// ProductQuantityFromDatabase
			// 
			this.ProductQuantityFromDatabase.HeaderText = "Stan z bazy";
			this.ProductQuantityFromDatabase.Name = "ProductQuantityFromDatabase";
			this.ProductQuantityFromDatabase.ReadOnly = true;
			// 
			// ProductQuantityStableFromDatabase
			// 
			this.ProductQuantityStableFromDatabase.HeaderText = "Stan początkowy";
			this.ProductQuantityStableFromDatabase.Name = "ProductQuantityStableFromDatabase";
			this.ProductQuantityStableFromDatabase.ReadOnly = true;
			// 
			// ProductClientAdded
			// 
			this.ProductClientAdded.HeaderText = "Dodał klient";
			this.ProductClientAdded.Name = "ProductClientAdded";
			this.ProductClientAdded.ReadOnly = true;
			// 
			// ProductClientModified
			// 
			this.ProductClientModified.HeaderText = "Ostatnio zmodyfikował";
			this.ProductClientModified.Name = "ProductClientModified";
			this.ProductClientModified.ReadOnly = true;
			// 
			// ProductAddedDate
			// 
			this.ProductAddedDate.HeaderText = "Data dodania";
			this.ProductAddedDate.Name = "ProductAddedDate";
			this.ProductAddedDate.ReadOnly = true;
			// 
			// ProductModificationDate
			// 
			this.ProductModificationDate.HeaderText = "Ostatnia data modyfikacji";
			this.ProductModificationDate.Name = "ProductModificationDate";
			this.ProductModificationDate.ReadOnly = true;
			// 
			// saveFileExportDialog
			// 
			this.saveFileExportDialog.Filter = "Plik tekstowy (*.csv)|*.csv";
			// 
			// toolStrip
			// 
			this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toolStrip.AutoSize = false;
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonPause,
            this.toolStripButtonStop,
            this.toolStripSeparator1,
            this.toolStripButtonExport,
            this.toolStripButtonPrint,
            this.toolStripSeparator2,
            this.toolStripButtonPreferences,
            this.toolStripSeparator3,
            this.toolStripButtonAbout});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(844, 39);
			this.toolStrip.Stretch = true;
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			// 
			// toolStripButtonStart
			// 
			this.toolStripButtonStart.AutoSize = false;
			this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStart.Image = global::PharmacyConditionServer.Properties.Resources.play;
			this.toolStripButtonStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStart.Name = "toolStripButtonStart";
			this.toolStripButtonStart.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonStart.Text = "Uruchom";
			this.toolStripButtonStart.Click += new System.EventHandler(this.ToolStripButtonStartClick);
			// 
			// toolStripButtonPause
			// 
			this.toolStripButtonPause.AutoSize = false;
			this.toolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPause.Enabled = false;
			this.toolStripButtonPause.Image = global::PharmacyConditionServer.Properties.Resources.pause;
			this.toolStripButtonPause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPause.Name = "toolStripButtonPause";
			this.toolStripButtonPause.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonPause.Text = "Wstrzymaj";
			// 
			// toolStripButtonStop
			// 
			this.toolStripButtonStop.AutoSize = false;
			this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStop.Enabled = false;
			this.toolStripButtonStop.Image = global::PharmacyConditionServer.Properties.Resources.stop;
			this.toolStripButtonStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStop.Name = "toolStripButtonStop";
			this.toolStripButtonStop.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonStop.Text = "Zatrzymaj";
			this.toolStripButtonStop.Click += new System.EventHandler(this.ToolStripButtonStopClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripButtonExport
			// 
			this.toolStripButtonExport.AutoSize = false;
			this.toolStripButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExport.Image = global::PharmacyConditionServer.Properties.Resources.entry_save;
			this.toolStripButtonExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonExport.Name = "toolStripButtonExport";
			this.toolStripButtonExport.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonExport.Text = "Exportuj dane do...";
			this.toolStripButtonExport.Click += new System.EventHandler(this.ToolStripButtonExportClick);
			// 
			// toolStripButtonPrint
			// 
			this.toolStripButtonPrint.AutoSize = false;
			this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.Enabled = false;
			this.toolStripButtonPrint.Image = global::PharmacyConditionServer.Properties.Resources.print;
			this.toolStripButtonPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonPrint.Text = "Drukuj...";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripButtonPreferences
			// 
			this.toolStripButtonPreferences.AutoSize = false;
			this.toolStripButtonPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPreferences.Image = global::PharmacyConditionServer.Properties.Resources.preferences;
			this.toolStripButtonPreferences.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPreferences.Name = "toolStripButtonPreferences";
			this.toolStripButtonPreferences.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonPreferences.Text = "Ustawienia...";
			this.toolStripButtonPreferences.Click += new System.EventHandler(this.ToolStripButtonPreferencesClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripButtonAbout
			// 
			this.toolStripButtonAbout.AutoSize = false;
			this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
			this.toolStripButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAbout.Name = "toolStripButtonAbout";
			this.toolStripButtonAbout.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonAbout.Text = "O programie...";
			this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAboutClick);
			// 
			// listBoxServerLog
			// 
			this.listBoxServerLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxServerLog.FormattingEnabled = true;
			this.listBoxServerLog.Location = new System.Drawing.Point(3, 3);
			this.listBoxServerLog.Name = "listBoxServerLog";
			this.listBoxServerLog.Size = new System.Drawing.Size(733, 329);
			this.listBoxServerLog.TabIndex = 2;
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageMain);
			this.tabControl.Controls.Add(this.tabPageNotMain);
			this.tabControl.Controls.Add(this.tabPageClients);
			this.tabControl.Controls.Add(this.tabPageHistory);
			this.tabControl.Controls.Add(this.tabPageLog);
			this.tabControl.Location = new System.Drawing.Point(-1, 3);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(848, 368);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageMain
			// 
			this.tabPageMain.Controls.Add(this.dataGridViewGood);
			this.tabPageMain.Location = new System.Drawing.Point(4, 22);
			this.tabPageMain.Name = "tabPageMain";
			this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMain.Size = new System.Drawing.Size(840, 342);
			this.tabPageMain.TabIndex = 0;
			this.tabPageMain.Text = "Zeskanowane produkty";
			this.tabPageMain.UseVisualStyleBackColor = true;
			// 
			// tabPageNotMain
			// 
			this.tabPageNotMain.Controls.Add(this.dataGridViewBad);
			this.tabPageNotMain.Location = new System.Drawing.Point(4, 22);
			this.tabPageNotMain.Name = "tabPageNotMain";
			this.tabPageNotMain.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageNotMain.Size = new System.Drawing.Size(840, 342);
			this.tabPageNotMain.TabIndex = 4;
			this.tabPageNotMain.Text = "Produkty niedostępne";
			this.tabPageNotMain.UseVisualStyleBackColor = true;
			// 
			// dataGridViewBad
			// 
			this.dataGridViewBad.AllowUserToAddRows = false;
			this.dataGridViewBad.AllowUserToDeleteRows = false;
			this.dataGridViewBad.AllowUserToResizeRows = false;
			this.dataGridViewBad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewBad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewBad.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewBad.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dataGridViewBad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NotProductId,
            this.NotProductDirtyBarcode,
            this.NotProductCleanBarcode,
            this.NotProductBarcodeType,
            this.NotProductQuantity,
            this.NotProductInsertedInto,
            this.NotProductClientAdded,
            this.NotProductClientModified,
            this.NotProductDateAdded,
            this.NotProductDateConnected});
			this.dataGridViewBad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridViewBad.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewBad.MultiSelect = false;
			this.dataGridViewBad.Name = "dataGridViewBad";
			this.dataGridViewBad.ReadOnly = true;
			this.dataGridViewBad.RowHeadersVisible = false;
			this.dataGridViewBad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewBad.Size = new System.Drawing.Size(834, 336);
			this.dataGridViewBad.TabIndex = 1;
			// 
			// NotProductId
			// 
			this.NotProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.NotProductId.HeaderText = "ID";
			this.NotProductId.Name = "NotProductId";
			this.NotProductId.ReadOnly = true;
			this.NotProductId.Visible = false;
			this.NotProductId.Width = 79;
			// 
			// NotProductDirtyBarcode
			// 
			this.NotProductDirtyBarcode.HeaderText = "Kod kreskowy (brudny)";
			this.NotProductDirtyBarcode.Name = "NotProductDirtyBarcode";
			this.NotProductDirtyBarcode.ReadOnly = true;
			this.NotProductDirtyBarcode.Visible = false;
			// 
			// NotProductCleanBarcode
			// 
			this.NotProductCleanBarcode.HeaderText = "Kod kreskowy";
			this.NotProductCleanBarcode.Name = "NotProductCleanBarcode";
			this.NotProductCleanBarcode.ReadOnly = true;
			// 
			// NotProductBarcodeType
			// 
			this.NotProductBarcodeType.HeaderText = "Typ kodu kreskowego";
			this.NotProductBarcodeType.Name = "NotProductBarcodeType";
			this.NotProductBarcodeType.ReadOnly = true;
			// 
			// NotProductQuantity
			// 
			this.NotProductQuantity.HeaderText = "Zliczony stan";
			this.NotProductQuantity.Name = "NotProductQuantity";
			this.NotProductQuantity.ReadOnly = true;
			// 
			// NotProductInsertedInto
			// 
			this.NotProductInsertedInto.HeaderText = "Powiązano z";
			this.NotProductInsertedInto.Name = "NotProductInsertedInto";
			this.NotProductInsertedInto.ReadOnly = true;
			// 
			// NotProductClientAdded
			// 
			this.NotProductClientAdded.HeaderText = "Dodał klient";
			this.NotProductClientAdded.Name = "NotProductClientAdded";
			this.NotProductClientAdded.ReadOnly = true;
			// 
			// NotProductClientModified
			// 
			this.NotProductClientModified.HeaderText = "Powiązał";
			this.NotProductClientModified.Name = "NotProductClientModified";
			this.NotProductClientModified.ReadOnly = true;
			// 
			// NotProductDateAdded
			// 
			this.NotProductDateAdded.HeaderText = "Data dodania";
			this.NotProductDateAdded.Name = "NotProductDateAdded";
			this.NotProductDateAdded.ReadOnly = true;
			// 
			// NotProductDateConnected
			// 
			this.NotProductDateConnected.HeaderText = "Data powiązania";
			this.NotProductDateConnected.Name = "NotProductDateConnected";
			this.NotProductDateConnected.ReadOnly = true;
			// 
			// tabPageClients
			// 
			this.tabPageClients.Controls.Add(this.buttonDisconnectAllClients);
			this.tabPageClients.Controls.Add(this.buttonDisconnectSelectedClient);
			this.tabPageClients.Controls.Add(this.listBoxConnectedClients);
			this.tabPageClients.Location = new System.Drawing.Point(4, 22);
			this.tabPageClients.Name = "tabPageClients";
			this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageClients.Size = new System.Drawing.Size(840, 342);
			this.tabPageClients.TabIndex = 3;
			this.tabPageClients.Text = "Podłączeni klienci";
			this.tabPageClients.UseVisualStyleBackColor = true;
			// 
			// buttonDisconnectAllClients
			// 
			this.buttonDisconnectAllClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDisconnectAllClients.Enabled = false;
			this.buttonDisconnectAllClients.Location = new System.Drawing.Point(734, 56);
			this.buttonDisconnectAllClients.Name = "buttonDisconnectAllClients";
			this.buttonDisconnectAllClients.Size = new System.Drawing.Size(100, 47);
			this.buttonDisconnectAllClients.TabIndex = 1;
			this.buttonDisconnectAllClients.Text = "Rozłącz wszystkich klientów";
			this.buttonDisconnectAllClients.UseVisualStyleBackColor = true;
			// 
			// buttonDisconnectSelectedClient
			// 
			this.buttonDisconnectSelectedClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDisconnectSelectedClient.Enabled = false;
			this.buttonDisconnectSelectedClient.Location = new System.Drawing.Point(734, 3);
			this.buttonDisconnectSelectedClient.Name = "buttonDisconnectSelectedClient";
			this.buttonDisconnectSelectedClient.Size = new System.Drawing.Size(100, 47);
			this.buttonDisconnectSelectedClient.TabIndex = 0;
			this.buttonDisconnectSelectedClient.Text = "Rozłącz zaznaczonego klienta";
			this.buttonDisconnectSelectedClient.UseVisualStyleBackColor = true;
			// 
			// listBoxConnectedClients
			// 
			this.listBoxConnectedClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxConnectedClients.FormattingEnabled = true;
			this.listBoxConnectedClients.Location = new System.Drawing.Point(3, 3);
			this.listBoxConnectedClients.Name = "listBoxConnectedClients";
			this.listBoxConnectedClients.Size = new System.Drawing.Size(725, 329);
			this.listBoxConnectedClients.TabIndex = 2;
			// 
			// tabPageHistory
			// 
			this.tabPageHistory.Controls.Add(this.buttonDeleteAllHistorySessions);
			this.tabPageHistory.Controls.Add(this.buttonDeleteSelectedHistorySession);
			this.tabPageHistory.Controls.Add(this.buttonReadSelectedHistorySession);
			this.tabPageHistory.Controls.Add(this.listBoxSessionHistory);
			this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
			this.tabPageHistory.Name = "tabPageHistory";
			this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageHistory.Size = new System.Drawing.Size(840, 342);
			this.tabPageHistory.TabIndex = 1;
			this.tabPageHistory.Text = "Historia sesji";
			this.tabPageHistory.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteAllHistorySessions
			// 
			this.buttonDeleteAllHistorySessions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDeleteAllHistorySessions.Location = new System.Drawing.Point(734, 85);
			this.buttonDeleteAllHistorySessions.Name = "buttonDeleteAllHistorySessions";
			this.buttonDeleteAllHistorySessions.Size = new System.Drawing.Size(100, 35);
			this.buttonDeleteAllHistorySessions.TabIndex = 2;
			this.buttonDeleteAllHistorySessions.Text = "Skasuj wszystkie sesje";
			this.buttonDeleteAllHistorySessions.UseVisualStyleBackColor = true;
			this.buttonDeleteAllHistorySessions.Click += new System.EventHandler(this.ButtonDeleteAllHistorySessionsClick);
			// 
			// buttonDeleteSelectedHistorySession
			// 
			this.buttonDeleteSelectedHistorySession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDeleteSelectedHistorySession.Enabled = false;
			this.buttonDeleteSelectedHistorySession.Location = new System.Drawing.Point(734, 44);
			this.buttonDeleteSelectedHistorySession.Name = "buttonDeleteSelectedHistorySession";
			this.buttonDeleteSelectedHistorySession.Size = new System.Drawing.Size(100, 35);
			this.buttonDeleteSelectedHistorySession.TabIndex = 1;
			this.buttonDeleteSelectedHistorySession.Text = "Skasuj zaznaczoną sesję";
			this.buttonDeleteSelectedHistorySession.UseVisualStyleBackColor = true;
			// 
			// buttonReadSelectedHistorySession
			// 
			this.buttonReadSelectedHistorySession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonReadSelectedHistorySession.Location = new System.Drawing.Point(734, 3);
			this.buttonReadSelectedHistorySession.Name = "buttonReadSelectedHistorySession";
			this.buttonReadSelectedHistorySession.Size = new System.Drawing.Size(100, 35);
			this.buttonReadSelectedHistorySession.TabIndex = 0;
			this.buttonReadSelectedHistorySession.Text = "Wczytaj zaznaczoną sesję";
			this.buttonReadSelectedHistorySession.UseVisualStyleBackColor = true;
			this.buttonReadSelectedHistorySession.Click += new System.EventHandler(this.ButtonReadSelectedHistorySessionClick);
			// 
			// listBoxSessionHistory
			// 
			this.listBoxSessionHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxSessionHistory.FormattingEnabled = true;
			this.listBoxSessionHistory.Location = new System.Drawing.Point(3, 3);
			this.listBoxSessionHistory.Name = "listBoxSessionHistory";
			this.listBoxSessionHistory.Size = new System.Drawing.Size(725, 329);
			this.listBoxSessionHistory.TabIndex = 3;
			// 
			// tabPageLog
			// 
			this.tabPageLog.Controls.Add(this.buttonLogClean);
			this.tabPageLog.Controls.Add(this.buttonLogSave);
			this.tabPageLog.Controls.Add(this.listBoxServerLog);
			this.tabPageLog.Location = new System.Drawing.Point(4, 22);
			this.tabPageLog.Name = "tabPageLog";
			this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLog.Size = new System.Drawing.Size(840, 342);
			this.tabPageLog.TabIndex = 2;
			this.tabPageLog.Text = "Log pracy serwera i klientów";
			this.tabPageLog.UseVisualStyleBackColor = true;
			// 
			// buttonLogClean
			// 
			this.buttonLogClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLogClean.Enabled = false;
			this.buttonLogClean.Location = new System.Drawing.Point(742, 32);
			this.buttonLogClean.Name = "buttonLogClean";
			this.buttonLogClean.Size = new System.Drawing.Size(92, 23);
			this.buttonLogClean.TabIndex = 1;
			this.buttonLogClean.Text = "Wyczyść log";
			this.buttonLogClean.UseVisualStyleBackColor = true;
			// 
			// buttonLogSave
			// 
			this.buttonLogSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLogSave.Enabled = false;
			this.buttonLogSave.Location = new System.Drawing.Point(742, 3);
			this.buttonLogSave.Name = "buttonLogSave";
			this.buttonLogSave.Size = new System.Drawing.Size(92, 23);
			this.buttonLogSave.TabIndex = 0;
			this.buttonLogSave.Text = "Zapisz log...";
			this.buttonLogSave.UseVisualStyleBackColor = true;
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.tabControl);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(844, 371);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.LeftToolStripPanelVisible = false;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.RightToolStripPanelVisible = false;
			this.toolStripContainer.Size = new System.Drawing.Size(844, 410);
			this.toolStripContainer.TabIndex = 0;
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(844, 410);
			this.Controls.Add(this.toolStripContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(860, 448);
			this.Name = "MainForm";
			this.Text = "Pharmacy Condition Server";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Shown += new System.EventHandler(this.MainFormShown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).EndInit();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageMain.ResumeLayout(false);
			this.tabPageNotMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBad)).EndInit();
			this.tabPageClients.ResumeLayout(false);
			this.tabPageHistory.ResumeLayout(false);
			this.tabPageLog.ResumeLayout(false);
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewGood;
		private System.Windows.Forms.SaveFileDialog saveFileExportDialog;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton toolStripButtonStart;
		private System.Windows.Forms.ToolStripButton toolStripButtonPause;
		private System.Windows.Forms.ToolStripButton toolStripButtonStop;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButtonExport;
		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButtonPreferences;
		private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ListBox listBoxServerLog;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageMain;
		private System.Windows.Forms.TabPage tabPageHistory;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.TabPage tabPageLog;
		private System.Windows.Forms.ListBox listBoxSessionHistory;
		private System.Windows.Forms.TabPage tabPageClients;
		private System.Windows.Forms.Button buttonLogClean;
		private System.Windows.Forms.Button buttonLogSave;
		private System.Windows.Forms.Button buttonDeleteAllHistorySessions;
		private System.Windows.Forms.Button buttonDeleteSelectedHistorySession;
		private System.Windows.Forms.Button buttonReadSelectedHistorySession;
		private System.Windows.Forms.ListBox listBoxConnectedClients;
		private System.Windows.Forms.Button buttonDisconnectAllClients;
		private System.Windows.Forms.Button buttonDisconnectSelectedClient;
		private System.Windows.Forms.TabPage tabPageNotMain;
		private System.Windows.Forms.DataGridView dataGridViewBad;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductDirtyBarcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductCleanBarcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductLongName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductTypeOfBarcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityFromDatabase;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityStableFromDatabase;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductClientAdded;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductClientModified;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductAddedDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductModificationDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn NotProductId;
		private System.Windows.Forms.DataGridViewTextBoxColumn NotProductDirtyBarcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn NotProductCleanBarcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn NotProductBarcodeType;
		private System.Windows.Forms.DataGridViewTextBoxColumn NotProductQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn NotProductInsertedInto;
		private System.Windows.Forms.DataGridViewTextBoxColumn NotProductClientAdded;
		private System.Windows.Forms.DataGridViewTextBoxColumn NotProductClientModified;
		private System.Windows.Forms.DataGridViewTextBoxColumn NotProductDateAdded;
		private System.Windows.Forms.DataGridViewTextBoxColumn NotProductDateConnected;
	}
}


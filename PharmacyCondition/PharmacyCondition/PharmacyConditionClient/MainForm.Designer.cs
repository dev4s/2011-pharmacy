namespace PharmacyConditionClient
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductBarcodeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductDirtyBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductCleanBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductLongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductQuantityCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductClientAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductClientDateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonIncreaseQuantity = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDecreaseQuantity = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonPartialQuantity = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonAddBarcode = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonPreferences = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabelPrefix = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBoxBarcode = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabelLastReadedCode = new System.Windows.Forms.ToolStripLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductBarcodeType,
            this.ProductDirtyBarcode,
            this.ProductCleanBarcode,
            this.ProductLongName,
            this.ProductQuantityCount,
            this.ProductClientAdd,
            this.ProductClientDateModified});
			this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView.Location = new System.Drawing.Point(3, 3);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(918, 217);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.SelectionChanged += new System.EventHandler(this.DataGridViewSelectionChanged);
			// 
			// ProductID
			// 
			this.ProductID.HeaderText = "ID";
			this.ProductID.Name = "ProductID";
			this.ProductID.ReadOnly = true;
			this.ProductID.Visible = false;
			// 
			// ProductBarcodeType
			// 
			this.ProductBarcodeType.HeaderText = "Typ kodu";
			this.ProductBarcodeType.Name = "ProductBarcodeType";
			this.ProductBarcodeType.ReadOnly = true;
			this.ProductBarcodeType.Visible = false;
			// 
			// ProductDirtyBarcode
			// 
			this.ProductDirtyBarcode.HeaderText = "Kod z czytnika (brudny)";
			this.ProductDirtyBarcode.Name = "ProductDirtyBarcode";
			this.ProductDirtyBarcode.ReadOnly = true;
			this.ProductDirtyBarcode.Visible = false;
			// 
			// ProductCleanBarcode
			// 
			this.ProductCleanBarcode.HeaderText = "Kod z czytnika";
			this.ProductCleanBarcode.Name = "ProductCleanBarcode";
			this.ProductCleanBarcode.ReadOnly = true;
			// 
			// ProductLongName
			// 
			this.ProductLongName.HeaderText = "Nazwa";
			this.ProductLongName.Name = "ProductLongName";
			this.ProductLongName.ReadOnly = true;
			// 
			// ProductQuantityCount
			// 
			this.ProductQuantityCount.HeaderText = "Ilość";
			this.ProductQuantityCount.Name = "ProductQuantityCount";
			this.ProductQuantityCount.ReadOnly = true;
			// 
			// ProductClientAdd
			// 
			this.ProductClientAdd.HeaderText = "Data dodania";
			this.ProductClientAdd.Name = "ProductClientAdd";
			this.ProductClientAdd.ReadOnly = true;
			// 
			// ProductClientDateModified
			// 
			this.ProductClientDateModified.HeaderText = "Ostatnia data modyfikacji";
			this.ProductClientDateModified.Name = "ProductClientDateModified";
			this.ProductClientDateModified.ReadOnly = true;
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.dataGridView);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(924, 223);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.LeftToolStripPanelVisible = false;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.RightToolStripPanelVisible = false;
			this.toolStripContainer.Size = new System.Drawing.Size(924, 262);
			this.toolStripContainer.TabIndex = 14;
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
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
            this.toolStripButtonStop,
            this.toolStripSeparator5,
            this.toolStripButtonIncreaseQuantity,
            this.toolStripButtonDecreaseQuantity,
            this.toolStripButtonPartialQuantity,
            this.toolStripButtonAddBarcode,
            this.toolStripSeparator1,
            this.toolStripButtonPreferences,
            this.toolStripSeparator2,
            this.toolStripButtonAbout,
            this.toolStripSeparator3,
            this.toolStripLabelPrefix,
            this.toolStripSeparator6,
            this.toolStripTextBoxBarcode,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.toolStripLabelLastReadedCode});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(924, 39);
			this.toolStrip.Stretch = true;
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			// 
			// toolStripButtonStart
			// 
			this.toolStripButtonStart.AutoSize = false;
			this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStart.Image = global::PharmacyConditionClient.Properties.Resources.play;
			this.toolStripButtonStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStart.Name = "toolStripButtonStart";
			this.toolStripButtonStart.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonStart.Text = "Uruchom klienta";
			this.toolStripButtonStart.ToolTipText = "Uruchom klienta";
			this.toolStripButtonStart.Click += new System.EventHandler(this.ToolStripButtonStartClick);
			// 
			// toolStripButtonStop
			// 
			this.toolStripButtonStop.AutoSize = false;
			this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStop.Enabled = false;
			this.toolStripButtonStop.Image = global::PharmacyConditionClient.Properties.Resources.stop;
			this.toolStripButtonStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStop.Name = "toolStripButtonStop";
			this.toolStripButtonStop.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonStop.Text = "Zatrzymaj klienta";
			this.toolStripButtonStop.ToolTipText = "Zatrzymaj klienta";
			this.toolStripButtonStop.Click += new System.EventHandler(this.ToolStripButtonStopClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripButtonIncreaseQuantity
			// 
			this.toolStripButtonIncreaseQuantity.AutoSize = false;
			this.toolStripButtonIncreaseQuantity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonIncreaseQuantity.Enabled = false;
			this.toolStripButtonIncreaseQuantity.Image = global::PharmacyConditionClient.Properties.Resources.increase;
			this.toolStripButtonIncreaseQuantity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonIncreaseQuantity.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonIncreaseQuantity.Name = "toolStripButtonIncreaseQuantity";
			this.toolStripButtonIncreaseQuantity.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonIncreaseQuantity.Text = "(F9) Zwiększ stan";
			this.toolStripButtonIncreaseQuantity.Click += new System.EventHandler(this.ToolStripButtonIncreaseQuantityClick);
			// 
			// toolStripButtonDecreaseQuantity
			// 
			this.toolStripButtonDecreaseQuantity.AutoSize = false;
			this.toolStripButtonDecreaseQuantity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDecreaseQuantity.Enabled = false;
			this.toolStripButtonDecreaseQuantity.Image = global::PharmacyConditionClient.Properties.Resources.decrease;
			this.toolStripButtonDecreaseQuantity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonDecreaseQuantity.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDecreaseQuantity.Name = "toolStripButtonDecreaseQuantity";
			this.toolStripButtonDecreaseQuantity.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonDecreaseQuantity.Text = "(F10) Zmniejsz stan";
			this.toolStripButtonDecreaseQuantity.Click += new System.EventHandler(this.ToolStripButtonDecreaseQuantityClick);
			// 
			// toolStripButtonPartialQuantity
			// 
			this.toolStripButtonPartialQuantity.AutoSize = false;
			this.toolStripButtonPartialQuantity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPartialQuantity.Enabled = false;
			this.toolStripButtonPartialQuantity.Image = global::PharmacyConditionClient.Properties.Resources.change;
			this.toolStripButtonPartialQuantity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonPartialQuantity.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPartialQuantity.Name = "toolStripButtonPartialQuantity";
			this.toolStripButtonPartialQuantity.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonPartialQuantity.Text = "(F11) Częściowy stan";
			this.toolStripButtonPartialQuantity.Click += new System.EventHandler(this.ToolStripButtonPartialQuantityClick);
			// 
			// toolStripButtonAddBarcode
			// 
			this.toolStripButtonAddBarcode.AutoSize = false;
			this.toolStripButtonAddBarcode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddBarcode.Enabled = false;
			this.toolStripButtonAddBarcode.Image = global::PharmacyConditionClient.Properties.Resources.add_barcode;
			this.toolStripButtonAddBarcode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonAddBarcode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAddBarcode.Name = "toolStripButtonAddBarcode";
			this.toolStripButtonAddBarcode.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonAddBarcode.Text = "(F12) Dopisz kod";
			this.toolStripButtonAddBarcode.Click += new System.EventHandler(this.ToolStripButtonAddBarcodeClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripButtonPreferences
			// 
			this.toolStripButtonPreferences.AutoSize = false;
			this.toolStripButtonPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPreferences.Image = global::PharmacyConditionClient.Properties.Resources.preferences;
			this.toolStripButtonPreferences.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPreferences.Name = "toolStripButtonPreferences";
			this.toolStripButtonPreferences.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonPreferences.Text = "Ustawienia...";
			this.toolStripButtonPreferences.Click += new System.EventHandler(this.ToolStripButtonPreferencesClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripButtonAbout
			// 
			this.toolStripButtonAbout.AutoSize = false;
			this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAbout.Image = global::PharmacyConditionClient.Properties.Resources.about;
			this.toolStripButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAbout.Name = "toolStripButtonAbout";
			this.toolStripButtonAbout.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonAbout.Text = "O programie...";
			this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAboutClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripLabelPrefix
			// 
			this.toolStripLabelPrefix.Name = "toolStripLabelPrefix";
			this.toolStripLabelPrefix.Size = new System.Drawing.Size(113, 36);
			this.toolStripLabelPrefix.Text = "Włączono prefix(@)!";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripTextBoxBarcode
			// 
			this.toolStripTextBoxBarcode.Enabled = false;
			this.toolStripTextBoxBarcode.MaxLength = 14;
			this.toolStripTextBoxBarcode.Name = "toolStripTextBoxBarcode";
			this.toolStripTextBoxBarcode.Size = new System.Drawing.Size(120, 39);
			this.toolStripTextBoxBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolStripTextBoxBarcodeKeyPress);
			this.toolStripTextBoxBarcode.TextChanged += new System.EventHandler(this.ToolStripTextBoxBarcodeTextChanged);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(71, 36);
			this.toolStripLabel1.Text = "Ostatni kod:";
			// 
			// toolStripLabelLastReadedCode
			// 
			this.toolStripLabelLastReadedCode.Name = "toolStripLabelLastReadedCode";
			this.toolStripLabelLastReadedCode.Size = new System.Drawing.Size(51, 36);
			this.toolStripLabelLastReadedCode.Text = "... kod ...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 262);
			this.Controls.Add(this.toolStripContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(940, 300);
			this.Name = "MainForm";
			this.Text = "Pharmacy Condition Client";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton toolStripButtonIncreaseQuantity;
		private System.Windows.Forms.ToolStripButton toolStripButtonDecreaseQuantity;
		private System.Windows.Forms.ToolStripButton toolStripButtonPartialQuantity;
		private System.Windows.Forms.ToolStripButton toolStripButtonAddBarcode;
		private System.Windows.Forms.ToolStripButton toolStripButtonPreferences;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBarcode;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripLabel toolStripLabelLastReadedCode;
		private System.Windows.Forms.ToolStripButton toolStripButtonStart;
		private System.Windows.Forms.ToolStripButton toolStripButtonStop;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripLabel toolStripLabelPrefix;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductBarcodeType;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductDirtyBarcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductCleanBarcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductLongName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductClientAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductClientDateModified;
	}
}


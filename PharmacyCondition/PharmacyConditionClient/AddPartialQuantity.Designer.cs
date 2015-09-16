namespace PharmacyConditionClient
{
	partial class AddPartialQuantity
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPartialQuantity));
			this.comboBoxTypeOfCalculation = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxCalculating = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// comboBoxTypeOfCalculation
			// 
			this.comboBoxTypeOfCalculation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTypeOfCalculation.FormattingEnabled = true;
			this.comboBoxTypeOfCalculation.Items.AddRange(new object[] {
            "opak.",
            "tabl."});
			this.comboBoxTypeOfCalculation.Location = new System.Drawing.Point(170, 7);
			this.comboBoxTypeOfCalculation.Name = "comboBoxTypeOfCalculation";
			this.comboBoxTypeOfCalculation.Size = new System.Drawing.Size(82, 21);
			this.comboBoxTypeOfCalculation.TabIndex = 1;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Enabled = false;
			this.buttonAdd.Location = new System.Drawing.Point(5, 33);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "Wpisz";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(89, 33);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Anuluj";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// textBoxCalculating
			// 
			this.textBoxCalculating.Location = new System.Drawing.Point(5, 7);
			this.textBoxCalculating.MaxLength = 20;
			this.textBoxCalculating.Name = "textBoxCalculating";
			this.textBoxCalculating.Size = new System.Drawing.Size(159, 20);
			this.textBoxCalculating.TabIndex = 4;
			this.textBoxCalculating.TextChanged += new System.EventHandler(this.TextBoxCalculatingTextChanged);
			this.textBoxCalculating.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCalculatingKeyPress);
			// 
			// AddPartialQuantity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 61);
			this.Controls.Add(this.textBoxCalculating);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.comboBoxTypeOfCalculation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddPartialQuantity";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dodaj częściowy stan";
			this.Shown += new System.EventHandler(this.AddPartialQuantityShown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxTypeOfCalculation;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxCalculating;
	}
}
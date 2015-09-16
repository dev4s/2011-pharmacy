namespace PharmacyConditionServer
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxUpdateInterval = new System.Windows.Forms.ComboBox();
			this.checkBoxUpdate = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonConnectionTest = new System.Windows.Forms.Button();
			this.textBoxDbPort = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBoxDbName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxDbPharmacyId = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBoxDbSynchronizeInterval = new System.Windows.Forms.ComboBox();
			this.checkBoxDbSynchronize = new System.Windows.Forms.CheckBox();
			this.textBoxDbPassword = new System.Windows.Forms.TextBox();
			this.textBoxDbUsername = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxDbServerIp = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBoxServerPort = new System.Windows.Forms.TextBox();
			this.checkBoxAutomaticServerStart = new System.Windows.Forms.CheckBox();
			this.textBoxServerIp = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.comboBoxUpdateInterval);
			this.groupBox1.Controls.Add(this.checkBoxUpdate);
			this.groupBox1.Location = new System.Drawing.Point(4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(489, 49);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Automatyczne aktualizacje";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(427, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "dzień/dni";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(295, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Sprawdzaj co:";
			// 
			// comboBoxUpdateInterval
			// 
			this.comboBoxUpdateInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxUpdateInterval.Enabled = false;
			this.comboBoxUpdateInterval.FormattingEnabled = true;
			this.comboBoxUpdateInterval.Items.AddRange(new object[] {
            "1",
            "14",
            "2",
            "21",
            "28",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.comboBoxUpdateInterval.Location = new System.Drawing.Point(375, 17);
			this.comboBoxUpdateInterval.MaxDropDownItems = 10;
			this.comboBoxUpdateInterval.Name = "comboBoxUpdateInterval";
			this.comboBoxUpdateInterval.Size = new System.Drawing.Size(46, 21);
			this.comboBoxUpdateInterval.TabIndex = 1;
			// 
			// checkBoxUpdate
			// 
			this.checkBoxUpdate.AutoSize = true;
			this.checkBoxUpdate.Enabled = false;
			this.checkBoxUpdate.Location = new System.Drawing.Point(11, 21);
			this.checkBoxUpdate.Name = "checkBoxUpdate";
			this.checkBoxUpdate.Size = new System.Drawing.Size(58, 17);
			this.checkBoxUpdate.TabIndex = 0;
			this.checkBoxUpdate.Text = "Włącz";
			this.checkBoxUpdate.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonConnectionTest);
			this.groupBox2.Controls.Add(this.textBoxDbPort);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.textBoxDbName);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.textBoxDbPharmacyId);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.comboBoxDbSynchronizeInterval);
			this.groupBox2.Controls.Add(this.checkBoxDbSynchronize);
			this.groupBox2.Controls.Add(this.textBoxDbPassword);
			this.groupBox2.Controls.Add(this.textBoxDbUsername);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBoxDbServerIp);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.checkBoxShowPassword);
			this.groupBox2.Location = new System.Drawing.Point(4, 59);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(489, 199);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Baza danych";
			// 
			// buttonConnectionTest
			// 
			this.buttonConnectionTest.Location = new System.Drawing.Point(8, 168);
			this.buttonConnectionTest.Name = "buttonConnectionTest";
			this.buttonConnectionTest.Size = new System.Drawing.Size(184, 23);
			this.buttonConnectionTest.TabIndex = 9;
			this.buttonConnectionTest.Text = "Testuj podłączenie do bazy danych";
			this.buttonConnectionTest.UseVisualStyleBackColor = true;
			this.buttonConnectionTest.Click += new System.EventHandler(this.ButtonConnectionTestClick);
			// 
			// textBoxDbPort
			// 
			this.textBoxDbPort.Location = new System.Drawing.Point(255, 34);
			this.textBoxDbPort.MaxLength = 2000;
			this.textBoxDbPort.Name = "textBoxDbPort";
			this.textBoxDbPort.Size = new System.Drawing.Size(223, 20);
			this.textBoxDbPort.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(253, 18);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(111, 13);
			this.label12.TabIndex = 11;
			this.label12.Text = "Port (domyślnie: 3050)";
			// 
			// textBoxDbName
			// 
			this.textBoxDbName.Location = new System.Drawing.Point(9, 75);
			this.textBoxDbName.MaxLength = 2000;
			this.textBoxDbName.Name = "textBoxDbName";
			this.textBoxDbName.Size = new System.Drawing.Size(223, 20);
			this.textBoxDbName.TabIndex = 2;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 59);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 13);
			this.label11.TabIndex = 12;
			this.label11.Text = "Nazwa (alias):";
			// 
			// textBoxDbPharmacyId
			// 
			this.textBoxDbPharmacyId.Location = new System.Drawing.Point(255, 75);
			this.textBoxDbPharmacyId.Name = "textBoxDbPharmacyId";
			this.textBoxDbPharmacyId.Size = new System.Drawing.Size(223, 20);
			this.textBoxDbPharmacyId.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(253, 59);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(138, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "Identyfikator apteki (numer):";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(446, 146);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "minut";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(296, 146);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Synchronizuj co:";
			// 
			// comboBoxDbSynchronizeInterval
			// 
			this.comboBoxDbSynchronizeInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDbSynchronizeInterval.Enabled = false;
			this.comboBoxDbSynchronizeInterval.FormattingEnabled = true;
			this.comboBoxDbSynchronizeInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "30",
            "60",
            "90",
            "120",
            "150",
            "180",
            "360",
            "720",
            "1440"});
			this.comboBoxDbSynchronizeInterval.Location = new System.Drawing.Point(385, 143);
			this.comboBoxDbSynchronizeInterval.MaxDropDownItems = 10;
			this.comboBoxDbSynchronizeInterval.Name = "comboBoxDbSynchronizeInterval";
			this.comboBoxDbSynchronizeInterval.Size = new System.Drawing.Size(54, 21);
			this.comboBoxDbSynchronizeInterval.TabIndex = 8;
			// 
			// checkBoxDbSynchronize
			// 
			this.checkBoxDbSynchronize.AutoSize = true;
			this.checkBoxDbSynchronize.Enabled = false;
			this.checkBoxDbSynchronize.Location = new System.Drawing.Point(9, 145);
			this.checkBoxDbSynchronize.Name = "checkBoxDbSynchronize";
			this.checkBoxDbSynchronize.Size = new System.Drawing.Size(193, 17);
			this.checkBoxDbSynchronize.TabIndex = 7;
			this.checkBoxDbSynchronize.Text = "Synchronizuj bazy (lokalna i zdalna)";
			this.checkBoxDbSynchronize.UseVisualStyleBackColor = true;
			// 
			// textBoxDbPassword
			// 
			this.textBoxDbPassword.Location = new System.Drawing.Point(255, 115);
			this.textBoxDbPassword.Name = "textBoxDbPassword";
			this.textBoxDbPassword.Size = new System.Drawing.Size(224, 20);
			this.textBoxDbPassword.TabIndex = 5;
			// 
			// textBoxDbUsername
			// 
			this.textBoxDbUsername.Location = new System.Drawing.Point(9, 116);
			this.textBoxDbUsername.Name = "textBoxDbUsername";
			this.textBoxDbUsername.Size = new System.Drawing.Size(223, 20);
			this.textBoxDbUsername.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(252, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Hasło:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Nazwa użytkownika:";
			// 
			// textBoxDbServerIp
			// 
			this.textBoxDbServerIp.Location = new System.Drawing.Point(9, 34);
			this.textBoxDbServerIp.MaxLength = 2000;
			this.textBoxDbServerIp.Name = "textBoxDbServerIp";
			this.textBoxDbServerIp.Size = new System.Drawing.Size(223, 20);
			this.textBoxDbServerIp.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Adres IP:";
			// 
			// checkBoxShowPassword
			// 
			this.checkBoxShowPassword.AutoSize = true;
			this.checkBoxShowPassword.Checked = true;
			this.checkBoxShowPassword.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.checkBoxShowPassword.Location = new System.Drawing.Point(399, 99);
			this.checkBoxShowPassword.Name = "checkBoxShowPassword";
			this.checkBoxShowPassword.Size = new System.Drawing.Size(86, 17);
			this.checkBoxShowPassword.TabIndex = 6;
			this.checkBoxShowPassword.Text = "Pokaż hasło";
			this.checkBoxShowPassword.UseVisualStyleBackColor = true;
			this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPasswordCheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBoxServerPort);
			this.groupBox3.Controls.Add(this.checkBoxAutomaticServerStart);
			this.groupBox3.Controls.Add(this.textBoxServerIp);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(4, 264);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(489, 83);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Serwer";
			// 
			// textBoxServerPort
			// 
			this.textBoxServerPort.Location = new System.Drawing.Point(256, 32);
			this.textBoxServerPort.MaxLength = 5;
			this.textBoxServerPort.Name = "textBoxServerPort";
			this.textBoxServerPort.Size = new System.Drawing.Size(224, 20);
			this.textBoxServerPort.TabIndex = 1;
			// 
			// checkBoxAutomaticServerStart
			// 
			this.checkBoxAutomaticServerStart.AutoSize = true;
			this.checkBoxAutomaticServerStart.Enabled = false;
			this.checkBoxAutomaticServerStart.Location = new System.Drawing.Point(10, 59);
			this.checkBoxAutomaticServerStart.Name = "checkBoxAutomaticServerStart";
			this.checkBoxAutomaticServerStart.Size = new System.Drawing.Size(199, 17);
			this.checkBoxAutomaticServerStart.TabIndex = 2;
			this.checkBoxAutomaticServerStart.Text = "Automatyczne uruchomienie serwera";
			this.checkBoxAutomaticServerStart.UseVisualStyleBackColor = true;
			// 
			// textBoxServerIp
			// 
			this.textBoxServerIp.Location = new System.Drawing.Point(9, 32);
			this.textBoxServerIp.MaxLength = 15;
			this.textBoxServerIp.Name = "textBoxServerIp";
			this.textBoxServerIp.Size = new System.Drawing.Size(224, 20);
			this.textBoxServerIp.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(253, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Port:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Adres IP:";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(85, 353);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Anuluj";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(4, 353);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Zapisz";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 380);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ustawienia";
			this.Shown += new System.EventHandler(this.SettingsFormShown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxUpdateInterval;
		private System.Windows.Forms.CheckBox checkBoxUpdate;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxDbPharmacyId;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBoxDbSynchronizeInterval;
		private System.Windows.Forms.CheckBox checkBoxDbSynchronize;
		private System.Windows.Forms.TextBox textBoxDbPassword;
		private System.Windows.Forms.TextBox textBoxDbUsername;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxDbServerIp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBoxShowPassword;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBoxServerPort;
		private System.Windows.Forms.CheckBox checkBoxAutomaticServerStart;
		private System.Windows.Forms.TextBox textBoxServerIp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TextBox textBoxDbName;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxDbPort;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button buttonConnectionTest;
	}
}
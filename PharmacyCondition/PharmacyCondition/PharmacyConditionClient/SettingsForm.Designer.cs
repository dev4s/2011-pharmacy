﻿namespace PharmacyConditionClient
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
			this.checkBoxPrefix = new System.Windows.Forms.CheckBox();
			this.textBoxPrefix = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxComputerName = new System.Windows.Forms.TextBox();
			this.textBoxServerPort = new System.Windows.Forms.TextBox();
			this.textBoxServerIp = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonConnectionTest = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxPrefix);
			this.groupBox1.Controls.Add(this.textBoxPrefix);
			this.groupBox1.Location = new System.Drawing.Point(6, 110);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(481, 44);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Czytnik";
			// 
			// checkBoxPrefix
			// 
			this.checkBoxPrefix.AutoSize = true;
			this.checkBoxPrefix.Location = new System.Drawing.Point(10, 19);
			this.checkBoxPrefix.Name = "checkBoxPrefix";
			this.checkBoxPrefix.Size = new System.Drawing.Size(55, 17);
			this.checkBoxPrefix.TabIndex = 0;
			this.checkBoxPrefix.Text = "Prefix:";
			this.checkBoxPrefix.UseVisualStyleBackColor = true;
			this.checkBoxPrefix.CheckStateChanged += new System.EventHandler(this.CheckBoxPrefixCheckStateChanged);
			// 
			// textBoxPrefix
			// 
			this.textBoxPrefix.Enabled = false;
			this.textBoxPrefix.Location = new System.Drawing.Point(65, 17);
			this.textBoxPrefix.MaxLength = 1;
			this.textBoxPrefix.Name = "textBoxPrefix";
			this.textBoxPrefix.Size = new System.Drawing.Size(26, 20);
			this.textBoxPrefix.TabIndex = 1;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(87, 160);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Anuluj";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(6, 160);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Zapisz";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.textBoxComputerName);
			this.groupBox2.Controls.Add(this.textBoxServerPort);
			this.groupBox2.Controls.Add(this.textBoxServerIp);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(6, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(481, 102);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Połączenie do serwera";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nazwa klienta:";
			// 
			// textBoxComputerName
			// 
			this.textBoxComputerName.Location = new System.Drawing.Point(8, 32);
			this.textBoxComputerName.Name = "textBoxComputerName";
			this.textBoxComputerName.Size = new System.Drawing.Size(465, 20);
			this.textBoxComputerName.TabIndex = 0;
			// 
			// textBoxServerPort
			// 
			this.textBoxServerPort.Location = new System.Drawing.Point(249, 74);
			this.textBoxServerPort.MaxLength = 5;
			this.textBoxServerPort.Name = "textBoxServerPort";
			this.textBoxServerPort.Size = new System.Drawing.Size(224, 20);
			this.textBoxServerPort.TabIndex = 2;
			// 
			// textBoxServerIp
			// 
			this.textBoxServerIp.Location = new System.Drawing.Point(8, 74);
			this.textBoxServerIp.MaxLength = 15;
			this.textBoxServerIp.Name = "textBoxServerIp";
			this.textBoxServerIp.Size = new System.Drawing.Size(224, 20);
			this.textBoxServerIp.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(248, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Port:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Adres IP:";
			// 
			// buttonConnectionTest
			// 
			this.buttonConnectionTest.Location = new System.Drawing.Point(375, 160);
			this.buttonConnectionTest.Name = "buttonConnectionTest";
			this.buttonConnectionTest.Size = new System.Drawing.Size(112, 23);
			this.buttonConnectionTest.TabIndex = 4;
			this.buttonConnectionTest.Text = "Testuj połączenie";
			this.buttonConnectionTest.UseVisualStyleBackColor = true;
			this.buttonConnectionTest.Click += new System.EventHandler(this.ButtonConnectionTestClick);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 187);
			this.Controls.Add(this.buttonConnectionTest);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBoxPrefix;
		private System.Windows.Forms.TextBox textBoxPrefix;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxComputerName;
		private System.Windows.Forms.TextBox textBoxServerPort;
		private System.Windows.Forms.TextBox textBoxServerIp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonConnectionTest;
	}
}
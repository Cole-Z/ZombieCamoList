namespace ZombieCamoList
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			label1 = new Label();
			weaponList = new ListBox();
			panel1 = new Panel();
			groupBox1 = new GroupBox();
			btnClose = new Button();
			button1 = new Button();
			label16 = new Label();
			label15 = new Label();
			label14 = new Label();
			textBox11 = new TextBox();
			textBox10 = new TextBox();
			textBox9 = new TextBox();
			textBox8 = new TextBox();
			textBox7 = new TextBox();
			textBox6 = new TextBox();
			textBox5 = new TextBox();
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label13 = new Label();
			label12 = new Label();
			label11 = new Label();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			camoUnlockLabel = new Label();
			levelChallengeLabel = new Label();
			typeLabel = new Label();
			nameLabel = new Label();
			dgvCamoProgress = new DataGridView();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			camoComplete = new DataGridViewCheckBoxColumn();
			weaponBindingSource = new BindingSource(components);
			weaponInfoTextBox = new TextBox();
			zombieeeee = new OpenFileDialog();
			GetData = new Button();
			weaponNameLabel = new Label();
			progressBar1 = new ProgressBar();
			btnSaveProgress = new Button();
			percentBox = new TextBox();
			btnUpdateProgress = new Button();
			toolTip1 = new ToolTip(components);
			btnAddWeapon = new Button();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvCamoProgress).BeginInit();
			((System.ComponentModel.ISupportInitialize)weaponBindingSource).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = SystemColors.AppWorkspace;
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Location = new Point(77, 68);
			label1.Name = "label1";
			label1.Size = new Size(200, 23);
			label1.TabIndex = 0;
			label1.Text = "Weapon List";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += label1_Click;
			// 
			// weaponList
			// 
			weaponList.FormattingEnabled = true;
			weaponList.ItemHeight = 15;
			weaponList.Location = new Point(44, 108);
			weaponList.Name = "weaponList";
			weaponList.Size = new Size(269, 394);
			weaponList.TabIndex = 1;
			toolTip1.SetToolTip(weaponList, "Click on  a row to display  details");
			weaponList.SelectedIndexChanged += weaponList_SelectedIndexChanged;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.AppWorkspace;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(label2);
			panel1.Controls.Add(camoUnlockLabel);
			panel1.Controls.Add(levelChallengeLabel);
			panel1.Controls.Add(typeLabel);
			panel1.Controls.Add(nameLabel);
			panel1.Location = new Point(407, 108);
			panel1.Name = "panel1";
			panel1.Size = new Size(437, 303);
			panel1.TabIndex = 2;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = SystemColors.ButtonFace;
			groupBox1.Controls.Add(btnClose);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label16);
			groupBox1.Controls.Add(label15);
			groupBox1.Controls.Add(label14);
			groupBox1.Controls.Add(textBox11);
			groupBox1.Controls.Add(textBox10);
			groupBox1.Controls.Add(textBox9);
			groupBox1.Controls.Add(textBox8);
			groupBox1.Controls.Add(textBox7);
			groupBox1.Controls.Add(textBox6);
			groupBox1.Controls.Add(textBox5);
			groupBox1.Controls.Add(textBox4);
			groupBox1.Controls.Add(textBox3);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label13);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Location = new Point(87, 271);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(346, 415);
			groupBox1.TabIndex = 11;
			groupBox1.TabStop = false;
			groupBox1.Text = "Add a new weapon";
			groupBox1.Visible = false;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(16, 386);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(65, 23);
			btnClose.TabIndex = 25;
			btnClose.Text = "Close Window";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// button1
			// 
			button1.Location = new Point(244, 386);
			button1.Name = "button1";
			button1.Size = new Size(86, 23);
			button1.TabIndex = 25;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(6, 272);
			label16.Name = "label16";
			label16.Size = new Size(35, 15);
			label16.TabIndex = 24;
			label16.Text = "Tier 3";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(6, 177);
			label15.Name = "label15";
			label15.Size = new Size(35, 15);
			label15.TabIndex = 23;
			label15.Text = "Tier 2";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(6, 88);
			label14.Name = "label14";
			label14.Size = new Size(35, 15);
			label14.TabIndex = 22;
			label14.Text = "Tier 1";
			// 
			// textBox11
			// 
			textBox11.Location = new Point(126, 330);
			textBox11.Name = "textBox11";
			textBox11.Size = new Size(100, 23);
			textBox11.TabIndex = 21;
			// 
			// textBox10
			// 
			textBox10.Location = new Point(126, 301);
			textBox10.Name = "textBox10";
			textBox10.Size = new Size(100, 23);
			textBox10.TabIndex = 20;
			// 
			// textBox9
			// 
			textBox9.Location = new Point(126, 272);
			textBox9.Name = "textBox9";
			textBox9.Size = new Size(100, 23);
			textBox9.TabIndex = 19;
			// 
			// textBox8
			// 
			textBox8.Location = new Point(126, 233);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(100, 23);
			textBox8.TabIndex = 18;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(126, 204);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(100, 23);
			textBox7.TabIndex = 17;
			// 
			// textBox6
			// 
			textBox6.Location = new Point(126, 174);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(100, 23);
			textBox6.TabIndex = 16;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(126, 137);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(100, 23);
			textBox5.TabIndex = 15;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(126, 112);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(100, 23);
			textBox4.TabIndex = 14;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(126, 85);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 23);
			textBox3.TabIndex = 13;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(211, 26);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 12;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(61, 26);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 11;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(81, 333);
			label13.Name = "label13";
			label13.Size = new Size(39, 15);
			label13.TabIndex = 10;
			label13.Text = "Camo";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(61, 304);
			label12.Name = "label12";
			label12.Size = new Size(60, 15);
			label12.TabIndex = 9;
			label12.Text = "Challenge";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(87, 275);
			label11.Name = "label11";
			label11.Size = new Size(34, 15);
			label11.TabIndex = 8;
			label11.Text = "Level";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(81, 236);
			label10.Name = "label10";
			label10.Size = new Size(39, 15);
			label10.TabIndex = 7;
			label10.Text = "Camo";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(61, 207);
			label9.Name = "label9";
			label9.Size = new Size(60, 15);
			label9.TabIndex = 6;
			label9.Text = "Challenge";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(86, 177);
			label8.Name = "label8";
			label8.Size = new Size(34, 15);
			label8.TabIndex = 5;
			label8.Text = "Level";
			label8.Click += label8_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(81, 140);
			label7.Name = "label7";
			label7.Size = new Size(39, 15);
			label7.TabIndex = 4;
			label7.Text = "Camo";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(62, 115);
			label6.Name = "label6";
			label6.Size = new Size(60, 15);
			label6.TabIndex = 3;
			label6.Text = "Challenge";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(86, 88);
			label5.Name = "label5";
			label5.Size = new Size(34, 15);
			label5.TabIndex = 2;
			label5.Text = "Level";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(174, 29);
			label4.Name = "label4";
			label4.Size = new Size(31, 15);
			label4.TabIndex = 1;
			label4.Text = "Type";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(16, 29);
			label3.Name = "label3";
			label3.Size = new Size(39, 15);
			label3.TabIndex = 0;
			label3.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 178);
			label2.Name = "label2";
			label2.Size = new Size(222, 15);
			label2.TabIndex = 8;
			label2.Text = "Camos Unlocked at Level: (Gold Enigma)\r\n";
			// 
			// camoUnlockLabel
			// 
			camoUnlockLabel.BackColor = SystemColors.ButtonFace;
			camoUnlockLabel.BorderStyle = BorderStyle.FixedSingle;
			camoUnlockLabel.Location = new Point(18, 193);
			camoUnlockLabel.Name = "camoUnlockLabel";
			camoUnlockLabel.Size = new Size(400, 73);
			camoUnlockLabel.TabIndex = 3;
			camoUnlockLabel.Text = "Camo Unlock";
			// 
			// levelChallengeLabel
			// 
			levelChallengeLabel.BackColor = SystemColors.ButtonFace;
			levelChallengeLabel.BorderStyle = BorderStyle.FixedSingle;
			levelChallengeLabel.Location = new Point(18, 52);
			levelChallengeLabel.Name = "levelChallengeLabel";
			levelChallengeLabel.Size = new Size(400, 106);
			levelChallengeLabel.TabIndex = 2;
			levelChallengeLabel.Text = "Levels and Challenges";
			// 
			// typeLabel
			// 
			typeLabel.AutoSize = true;
			typeLabel.Location = new Point(151, 24);
			typeLabel.Name = "typeLabel";
			typeLabel.Size = new Size(31, 15);
			typeLabel.TabIndex = 1;
			typeLabel.Text = "Type";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new Point(18, 24);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(39, 15);
			nameLabel.TabIndex = 0;
			nameLabel.Text = "Name";
			// 
			// dgvCamoProgress
			// 
			dgvCamoProgress.AutoGenerateColumns = false;
			dgvCamoProgress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCamoProgress.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, camoComplete });
			dgvCamoProgress.DataSource = weaponBindingSource;
			dgvCamoProgress.Location = new Point(439, 417);
			dgvCamoProgress.Name = "dgvCamoProgress";
			dgvCamoProgress.Size = new Size(375, 210);
			dgvCamoProgress.TabIndex = 4;
			dgvCamoProgress.CellContentClick += dgvCamoProgress_CellContentClick;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			nameDataGridViewTextBoxColumn.HeaderText = "Name";
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// typeDataGridViewTextBoxColumn
			// 
			typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			typeDataGridViewTextBoxColumn.HeaderText = "Type";
			typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			// 
			// camoComplete
			// 
			camoComplete.HeaderText = "Camo Complete";
			camoComplete.Name = "camoComplete";
			// 
			// weaponBindingSource
			// 
			weaponBindingSource.DataSource = typeof(Weapon);
			// 
			// weaponInfoTextBox
			// 
			weaponInfoTextBox.Location = new Point(489, 70);
			weaponInfoTextBox.Name = "weaponInfoTextBox";
			weaponInfoTextBox.Size = new Size(355, 23);
			weaponInfoTextBox.TabIndex = 4;
			weaponInfoTextBox.TextChanged += weaponInfoTextBox_TextChanged;
			// 
			// zombieeeee
			// 
			zombieeeee.FileName = "openFileDialog1";
			// 
			// GetData
			// 
			GetData.BackColor = SystemColors.ButtonFace;
			GetData.Location = new Point(44, 506);
			GetData.Name = "GetData";
			GetData.Size = new Size(75, 23);
			GetData.TabIndex = 3;
			GetData.Text = "Open File";
			GetData.UseVisualStyleBackColor = false;
			GetData.Click += GetData_Click;
			// 
			// weaponNameLabel
			// 
			weaponNameLabel.AutoSize = true;
			weaponNameLabel.BackColor = SystemColors.ButtonFace;
			weaponNameLabel.Location = new Point(407, 72);
			weaponNameLabel.Name = "weaponNameLabel";
			weaponNameLabel.Size = new Size(76, 15);
			weaponNameLabel.TabIndex = 5;
			weaponNameLabel.Text = "Weapon Title";
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(439, 633);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(375, 23);
			progressBar1.TabIndex = 6;
			// 
			// btnSaveProgress
			// 
			btnSaveProgress.BackColor = SystemColors.ButtonFace;
			btnSaveProgress.Location = new Point(439, 662);
			btnSaveProgress.Name = "btnSaveProgress";
			btnSaveProgress.Size = new Size(124, 23);
			btnSaveProgress.TabIndex = 7;
			btnSaveProgress.Text = "Save to File";
			btnSaveProgress.UseVisualStyleBackColor = false;
			btnSaveProgress.Click += btnSaveProgress_Click;
			// 
			// percentBox
			// 
			percentBox.Location = new Point(714, 663);
			percentBox.Name = "percentBox";
			percentBox.Size = new Size(100, 23);
			percentBox.TabIndex = 8;
			percentBox.Text = "%";
			// 
			// btnUpdateProgress
			// 
			btnUpdateProgress.Location = new Point(569, 662);
			btnUpdateProgress.Name = "btnUpdateProgress";
			btnUpdateProgress.Size = new Size(139, 23);
			btnUpdateProgress.TabIndex = 9;
			btnUpdateProgress.Text = "Update Progress Grid";
			btnUpdateProgress.UseVisualStyleBackColor = true;
			btnUpdateProgress.Click += btnUpdateProgress_Click;
			// 
			// btnAddWeapon
			// 
			btnAddWeapon.Location = new Point(193, 506);
			btnAddWeapon.Name = "btnAddWeapon";
			btnAddWeapon.Size = new Size(120, 23);
			btnAddWeapon.TabIndex = 10;
			btnAddWeapon.Text = "Add a new weapon";
			btnAddWeapon.UseVisualStyleBackColor = true;
			btnAddWeapon.Click += btnAddWeapon_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(910, 722);
			Controls.Add(groupBox1);
			Controls.Add(btnAddWeapon);
			Controls.Add(btnUpdateProgress);
			Controls.Add(percentBox);
			Controls.Add(btnSaveProgress);
			Controls.Add(progressBar1);
			Controls.Add(dgvCamoProgress);
			Controls.Add(weaponNameLabel);
			Controls.Add(weaponInfoTextBox);
			Controls.Add(GetData);
			Controls.Add(panel1);
			Controls.Add(weaponList);
			Controls.Add(label1);
			MaximizeBox = false;
			MaximumSize = new Size(926, 761);
			MinimizeBox = false;
			MinimumSize = new Size(926, 761);
			Name = "Form1";
			Text = "MW3 Zombie Camo Tracker";
			Load += Form1_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvCamoProgress).EndInit();
			((System.ComponentModel.ISupportInitialize)weaponBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ListBox weaponList;
		private Panel panel1;
		private OpenFileDialog zombieeeee;
		private Button GetData;
		private TextBox weaponInfoTextBox;
		private Label levelChallengeLabel;
		private Label typeLabel;
		private Label nameLabel;
		private Label camoUnlockLabel;
		private Label weaponNameLabel;
		private DataGridView dgvCamoProgress;
		private BindingSource weaponBindingSource;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private DataGridViewCheckBoxColumn camoComplete;
		private ProgressBar progressBar1;
		private Button btnSaveProgress;
		private Label label2;
		private TextBox percentBox;
		private Button btnUpdateProgress;
		private ToolTip toolTip1;
		private Button btnAddWeapon;
		private GroupBox groupBox1;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private TextBox textBox1;
		private Label label13;
		private Label label12;
		private Label label11;
		private Label label10;
		private TextBox textBox2;
		private Label label16;
		private Label label15;
		private Label label14;
		private TextBox textBox11;
		private TextBox textBox10;
		private TextBox textBox9;
		private TextBox textBox8;
		private TextBox textBox7;
		private TextBox textBox6;
		private TextBox textBox5;
		private TextBox textBox4;
		private TextBox textBox3;
		private Button btnClose;
		private Button button1;
	}
}

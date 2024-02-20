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
			panel1.SuspendLayout();
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
			weaponList.Size = new Size(269, 544);
			weaponList.TabIndex = 1;
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
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 178);
			label2.Name = "label2";
			label2.Size = new Size(140, 15);
			label2.TabIndex = 8;
			label2.Text = "Camos Unlocked at Level";
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
			GetData.Location = new Point(44, 662);
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
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(910, 722);
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
	}
}

using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using System.Xml;
using System.Linq;
using System.IO;

/* This project is based off of Call of Duty's Modern Warfare III Zombies.
 * Zombies, is a classic game mode that has been out since 2008 and been a staple in the Call of Duty Commnunity,
 * and with every new Call of Duty game released, a new updated version of Zombies would be included. Soon, challenges
 * were added to unlock in game items and a popular one for most players is the Zombies Mastery Camo Completion.
 * The idea is that the player must use all weapons in the game and complete certain challenges to unlock camos for each weapon, 
 * once each weapon is complete, the player can unlock the 'Mastery Camo' which is very long process. How this project helps, 
 * is by acting as a centralized area for the players progress, since there is not progress checking in the game itself. Due to this
 * it can be difficult and time consuimg to see where you are and our setting up plan to be efficient as possible. This projects aims to 
 * provide a clear list of all MWIII weapons as well as the detailed information for challenges and camos for each gun.
 * There is also component to save progress so you can see how much longer you have to go. I am currently using this project for my camo challenges and it helps
 * with staying orgainized and on top of what I need to do next. A small video showing the functionality will be provided as well!  
 */

namespace ZombieCamoList
{
	public partial class Form1 : Form
	{
		// Class level variables 

		List<int> progressIdx = new List<int>();
		Weapon[] weapons = new Weapon[100];
		string progressFile = "progress.txt";
		public string myFile;
		public int recordCount;

		// Tiers on the MW3 Zombies map
		public enum ZoneTier
		{
			Tier1, Tier2, Tier3
		}

		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		/*######################################################################################################################
		 * 
		*/

		private void GetData_Click(object sender, EventArgs e)
		{
			zombieeeee.ShowDialog();
			myFile = zombieeeee.FileName;

			try
			{
				using (StreamReader sr = File.OpenText(myFile))
				{
					recordCount = File.ReadLines(myFile).Count() - 1;

					weapons = new Weapon[recordCount];

					sr.ReadLine();
					int i = 0;
					while (sr.Peek() != -1 && i < recordCount)
					{
						string[] weaponTemp = sr.ReadLine().Split(",");
						// Create a new instance of Weapon and add it to the weapons array
						Weapon newWeapon = new Weapon(weaponTemp[0], weaponTemp[1]);
						weapons[i] = newWeapon;
						i++;
					}
					sr.Close();
					MessageBox.Show(i.ToString() + " Weapon Classes were read in.", "Data Uploaded");

					// populate weapon levels
					using (StreamReader sr2 = File.OpenText(myFile))
					{
						sr2.ReadLine();
						int j = 0;
						while (sr2.Peek() != -1 && j < recordCount)
						{
							string line = sr2.ReadLine();
							string[] weaponTemp = line.Split(",");
							Weapon currentWeapon = weapons[j];

							// Add the levels, challenges, and camos to the current weapon
							for (int k = 2; k < weaponTemp.Length; k += 3) // increment by 3 to grab fields (Level, Challenge, Camo).
							{
								if (k + 2 < weaponTemp.Length)
								{
									// add WeaponLevel to the Levels list of the corresponding weapon
									currentWeapon.Levels.Add(new WeaponLevel(int.Parse(weaponTemp[k]), weaponTemp[k + 1], weaponTemp[k + 2]));
								}
							}
							j++;
						}
						sr2.Close();
					}

					PopulateWeaponList();
					GetData.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error parsing file: {ex.Message}", "Error");
			}

			// creating the datagrid view and using weapons as data source

			dgvCamoProgress.DataSource = weapons;
			dgvCamoProgress.Columns[0].Width = 115;
			dgvCamoProgress.Columns[1].Width = 115;
			dgvCamoProgress.RowHeadersWidth = 30;

			LoadCheckboxStatus(); // call LoadCheckboxStatus(); to update progress without user interaction.
			ProgressBar();        // call ProgressBar(); for visual on progression on camos.
		}

		/*######################################################################################################################
		*/

		private void weaponList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (weaponList.SelectedItem != null)
			{
				weaponInfoTextBox.Clear();
				string selectedWeaponInfo = weaponList.SelectedItem.ToString();
				weaponInfoTextBox.Text = selectedWeaponInfo;
			}
			// Check if an item is selected
			if (weaponList.SelectedIndex != -1)
			{
				Weapon selectedWeapon = weapons[weaponList.SelectedIndex];
				nameLabel.Text = "Name: " + selectedWeapon.Name;
				typeLabel.Text = "Type: " + selectedWeapon.Type;

				levelChallengeLabel.Text = "";
				camoUnlockLabel.Text = "";

				foreach (var level in selectedWeapon.Levels)
				{
					levelChallengeLabel.Text += $"Level {level.Level}: {level.Challenge}\n";
					camoUnlockLabel.Text += $"Camo Unlock {level.Level}: {level.CamoUnlock}\n";
				}
			}
		}

		/*######################################################################################################################
		 * 
		 * // populates the listbox with weapon "Name" and "Type" from ShowWeaponInfo() in the Weapon.cs class.
		*/

		private void PopulateWeaponList()
		{
			if (weapons != null)
			{
				weaponList.Items.Clear();

				foreach (var weapon in weapons)
				{
					string weaponInfo = weapon.ShowWeaponInfo();
					weaponList.Items.Add(weaponInfo);
				}

				label1.Text = "Showing all MW3 weapons";
			}
			else
			{
				MessageBox.Show("No weapon data available.", "Error");
			}
		}

		/*######################################################################################################################
		*/

		private void LoadCheckboxStatus()
		{
			try
			{
				if (File.Exists(progressFile))
				{
					List<string> checkboxStatuses = new List<string>(File.ReadAllLines(progressFile));
					for (int i = 0; i < checkboxStatuses.Count && i < dgvCamoProgress.Rows.Count; i++)
					{
						bool isChecked = Convert.ToBoolean(checkboxStatuses[i]);
						dgvCamoProgress.Rows[i].Cells[2].Value = isChecked; // getting checkbox bool
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading checkbox statuses: {ex.Message}", "Error");
			}
		}

		/*######################################################################################################################
		*/

		private void SaveCheckboxStatus()
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(progressFile))
				{
					foreach (DataGridViewRow row in dgvCamoProgress.Rows)
					{
						bool isChecked = Convert.ToBoolean(row.Cells[2].Value); // setting checkbox bool
						sw.WriteLine(isChecked);
					}
				}
				MessageBox.Show("Checkbox statuses saved successfully.", "Success!");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error saving checkbox statuses: {ex.Message}", "Error");
			}
		}

		/*######################################################################################################################
		 * 
		 * Same method as SaveCheckboxStatus(), but getting rid of a message dialog for updated save.
		*/

		private void UpdatedSave()
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(progressFile))
				{
					foreach (DataGridViewRow row in dgvCamoProgress.Rows)
					{
						bool isChecked = Convert.ToBoolean(row.Cells[2].Value);
						sw.WriteLine(isChecked);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error saving checkbox statuses: {ex.Message}", "Error");
			}
		}

		/*######################################################################################################################
		 * Method to calculate length of progressBar1
		*/

		private void ProgressBar()
		{
			try
			{
				int totalLines = 44; // length of the weapon list 
				int count = 0;

				using (StreamReader sr = new StreamReader(progressFile))
				{
					for (int i = 0; i < totalLines; i++)
					{
						string line = sr.ReadLine();
						if (line != null && line.Trim().ToLower() == "true")
						{
							count++;
						}
					}
				}
				double progress = (double)count / totalLines * 100;

				// Update the progress bar value based on number of true checks
				progressBar1.Value = (int)progress;
				percentBox.Text = progress.ToString("0") + "% Complete!";

			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
		}

		/*######################################################################################################################
		 * 
		 * Button Methods
		*/

		// Button to update progress while the app is running.
		private void btnUpdateProgress_Click(object sender, EventArgs e)
		{
			UpdatedSave();        // save
			LoadCheckboxStatus(); // load
			ProgressBar();        // update progress bar
		}

		///  Button to add a weapon to the list box. Does not save yet, need to add method to save the file.
		
		private void button1_Click(object sender, EventArgs e)
		{
			// Weapon class
			string name = textBox1.Text;
			string type = textBox2.Text;

			// Weapon Levels class
			string lvlOne = textBox3.Text;
			string challOne = textBox4.Text;
			string camoOne = textBox5.Text;

			string lvlTwo = textBox6.Text;
			string challTwo = textBox7.Text;
			string camoTwo = textBox8.Text;

			string lvlThree = textBox9.Text;
			string challThree = textBox10.Text;
			string camoThree = textBox11.Text;

			if (weapons.Length >= 99)
			{
				MessageBox.Show("Weapon list is full, remove an item to update.", "Error");
			}
			else if (name == "" || type == "")
			{
				MessageBox.Show("Please enter the Name and Type", "Missing Fields!");
			}
			else
			{

				Weapon newWeapon = new Weapon(name, type);
				newWeapon.Levels.Add(new WeaponLevel(int.Parse(lvlOne), challOne, camoOne));
				newWeapon.Levels.Add(new WeaponLevel(int.Parse(lvlTwo), challTwo, camoTwo));
				newWeapon.Levels.Add(new WeaponLevel(int.Parse(lvlThree), challThree, camoThree));

				// Add the new weapon to the array
				weapons[weapons.Length - 1] = newWeapon;

				MessageBox.Show("New weapon added successfully!", "Success");

				PopulateWeaponList();
			}
		}

		private void btnSaveProgress_Click(object sender, EventArgs e)
		{
			SaveCheckboxStatus();
		}


		private void btnAddWeapon_Click(object sender, EventArgs e)
		{
			groupBox1.Show();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			textBox1.Text = string.Empty;
			textBox2.Text = string.Empty;
			textBox3.Text = string.Empty;
			textBox4.Text = string.Empty;
			textBox5.Text = string.Empty;
			textBox6.Text = string.Empty;
			textBox7.Text = string.Empty;
			textBox8.Text = string.Empty;
			textBox9.Text = string.Empty;
			textBox10.Text = string.Empty;
			textBox11.Text = string.Empty;
			groupBox1.Hide();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void weaponInfoTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void dgvCamoProgress_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}
	}
}

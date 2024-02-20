using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace ZombieCamoList
{
	public class LoadoutBuilder
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string Description { get; set; }
        public string AttachmentOne { get; set; }
		public string AttachmentTwo { get; set; }
		public string AttachmentThree { get; set; }
		public string AttachmentFour { get; set; }
		public string AttachmentFive { get; set; }
		//public Bitmap WeaponImage { get; set; }

		public string loadOutFile = "loadouts.txt";
		List<LoadoutBuilder> loadouts = new List<LoadoutBuilder>();


		public LoadoutBuilder(string name, string type, string desc, string aOne, string aTwo, string aThree, string aFour, string aFive)
		{
			Name = name;
			Type = type;
			Description = desc;
			AttachmentOne = aOne;
			AttachmentTwo = aTwo;
			AttachmentThree = aThree;
			AttachmentFour = aFour;
			AttachmentFive = aFive;
		}

		public string BuildLoadout()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Name: " + Name + "\n");
			sb.Append("Type: " + Type + "\n");
			sb.Append("\nDescription: " + Description + "\n");
			sb.Append(AttachmentOne + ",");
			sb.Append(AttachmentTwo + ",");
			sb.Append(AttachmentThree + ",");
			sb.Append(AttachmentFour + ",");
			sb.Append(AttachmentFive + "," + "\n");	
			return sb.ToString();
		}

		public void ReadLoadOutSpecs()
		{
			try
			{
				if (File.Exists(loadOutFile))
				{
					using (StreamReader sr = File.OpenText(loadOutFile))
					{
						string header = sr.ReadLine(); // skip header line

						int count = 0;
						while (sr.Peek() != -1)
						{
							string[] loadOutTemp = sr.ReadLine().Split(",");
							if (loadOutTemp.Length != 8)
							{
								MessageBox.Show("Invalid loadout data.", "Error");
								return;
							}

							LoadoutBuilder loadOuts = new LoadoutBuilder(loadOutTemp[0], loadOutTemp[1], loadOutTemp[2], loadOutTemp[3],
																		  loadOutTemp[4], loadOutTemp[5], loadOutTemp[6], loadOutTemp[7]);
							loadouts.Add(loadOuts);
							count++;
						}

						MessageBox.Show($"{count} Loadouts were read in.", "Data Uploaded");

						// Process the loaded data here or raise an event/callback

						foreach (var loadout in loadouts)
						{
							switch (loadout.Type)
							{
								case "Assault Rifle":
									// AR
									break;
								case "Sniper Rifle":
									// SR
									break;
								case "SMG":
									// SMG
									break;
								default:
									// Handle unknown weapon types
									break;
							}
						}
					}
				}
				else
				{
					MessageBox.Show("Loadout file does not exist.", "Error");
				}
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show("Loadout file not found.", "Error");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}", "Error");
			}
		}
	}
}

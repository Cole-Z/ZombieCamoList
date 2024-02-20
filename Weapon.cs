using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZombieCamoList
{
	public class Weapon
	{
		public string Name { get; set; }
        public string Type { get; set; }
		public List<WeaponLevel> Levels { get; set; }

		// Constructor 
		public Weapon(string name, string type) 
		{
			Name = name;
			Type = type;
			Levels = new List<WeaponLevel>();

		}

		public string ShowWeaponInfo()
		{
			StringBuilder str = new StringBuilder();
			str.Append("Weapon: " + Name + " : Weapon Class: " + Type);
			return str.ToString();
		}
	}
	
	// Created an additional class for weapon levels due to multiple levels per weapon per each camo unlock.
	public class WeaponLevel
	{
		public int Level { get; set; }
		public string Challenge { get; set; }
		public string CamoUnlock { get; set; }

		public WeaponLevel(int level, string challenge, string camoUnlock)
		{
			Level = level;
			Challenge = challenge;
			CamoUnlock = camoUnlock;
		}
	}
}

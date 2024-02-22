using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieCamoList
{
	public class PointOfInterest
	{
        public string Name { get; set; }
		public string Region { get; set; }

		public PointOfInterest(string name, string region, string zoneDifficulty)
		{
			Name = name;
			Region = region;
		}
	}
}

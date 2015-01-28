using System;

namespace ProjetDesignPattern
{
	public class Location
	{
		
		public string name;
		public int x { get; set; }
		public int y { get; set; }

		public Location (String name)
		{
			setName (name);
		}
		public Location(int x, int y){
			this.x = x;
			this.y = y;
			name = x + "," + y;
		}

		public void setName(string value){
			this.name = value;
			String[] tmp = this.name.Split(',');
			this.x = int.Parse (tmp [0]);
			this.y = int.Parse (tmp [1]);
		}

		public bool Equals(Location l){
			if(l.x == x && l.y == y)
				return true;
			return false;
		}
	}
}


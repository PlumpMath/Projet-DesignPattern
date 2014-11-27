using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public class AucuneDefense:ComportementSeDefendre
	{

		public AucuneDefense ()
		{
			defense = 0;
		}

		public override int seDefendre(int degat){
			return degat - defense;
		}
	}
}


using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementTour : ComportementSeDeplacerJE
	{
		public DeplacementTour ()
		{
			this.déplacements = new int[][] { new int[] {2}, new int[] {4}, new int[] {6}, new int[] {8} };
			this.déplacementInfinie = true;
		}
    }
}


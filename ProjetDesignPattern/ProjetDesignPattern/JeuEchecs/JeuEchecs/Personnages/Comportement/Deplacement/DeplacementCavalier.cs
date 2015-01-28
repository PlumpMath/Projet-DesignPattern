using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementCavalier : ComportementSeDeplacerJE
	{
		public DeplacementCavalier ()
		{
			this.déplacements = new int[][]{ new int[] {2,2,4}, new int[] {2,2,6}, new int[] {4,4,2}, new int[] {4,4,8}, new int[] {6,6,2}, new int[] {6,6,8}, new int[] {8,8,4}, new int[] {8,8,6} };
			this.déplacementInfinie = false;
		}
    }
}


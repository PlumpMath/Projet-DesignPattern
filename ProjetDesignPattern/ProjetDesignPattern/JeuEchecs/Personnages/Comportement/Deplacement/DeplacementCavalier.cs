using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementCavalier : ComportementSeDeplacerJE
	{
		public DeplacementCavalier ()
		{
			this.déplacements = new int[][] { {2,2,4}, {2,2,6}, {4,4,2}, {4,4,8}, {6,6,2}, {6,6,8}, {8,8,4}, {8,8,6} };
			this.déplacementInfinie = false;
		}
    }
}


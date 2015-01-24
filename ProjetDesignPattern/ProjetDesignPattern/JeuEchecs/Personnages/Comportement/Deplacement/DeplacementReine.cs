using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementReine : ComportementSeDeplacerJE
	{
		public DeplacementReine ()
		{
			this.déplacements = new int[][] { {2}, {4}, {6}, {8}, {2,4}, {2,6}, {8,4}, {8,6} };
			this.déplacementInfinie = true;
		}
    }
}


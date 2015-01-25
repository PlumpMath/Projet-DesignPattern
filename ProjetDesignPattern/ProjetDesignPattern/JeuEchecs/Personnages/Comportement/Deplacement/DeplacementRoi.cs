using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementRoi : ComportementSeDeplacerJE
	{
		public DeplacementRoi ()
		{
			this.déplacements = new int[][] { new int[] {1}, new int[] {2}, new int[] {3}, new int[] {4}, new int[] {6}, new int[] {7}, new int[] {8}, new int[] {9} };
			this.déplacementInfinie = false;
		}
    }
}


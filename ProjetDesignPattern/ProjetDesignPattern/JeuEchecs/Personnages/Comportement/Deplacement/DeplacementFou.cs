using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{

	public class DeplacementFou : ComportementSeDeplacerJE
	{
		
		public DeplacementFou ()
		{
			this.déplacements = new int[][] { new int[] {2,4}, new int[] {2,6}, new int[] {8,4}, new int[] {8,6} };
			this.déplacementInfinie = true;
			this.déplacementLibre = true;
		}

    }
}


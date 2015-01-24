using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{

	public class DeplacementFou : ComportementSeDeplacerJE
	{
		
		public DeplacementFou ()
		{
			this.déplacements = new int[][] { {2,4}, {2,6}, {8,4}, {8,6} };
			this.déplacementInfinie = true;
		}

    }
}


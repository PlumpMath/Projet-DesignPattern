using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementRoi : ComportementSeDeplacerJE
	{
		public DeplacementRoi ()
		{
			this.déplacements = new int[,] { {1}, {2}, {3}, {4}, {6}, {7}, {8}, {9} };
			this.déplacementInfinie = false;
		}

		public override void deplacer(ZoneAbstraite zone)
        {
            throw new NotImplementedException();
        }

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone)
        {
            throw new NotImplementedException();
        }
    }
}


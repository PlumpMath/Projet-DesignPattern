using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementTour : ComportementSeDeplacerJE
	{
		public DeplacementTour ()
		{
			this.déplacements = new int[,] { {2}, {4}, {6}, {8} };
			this.déplacementInfinie = true;
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


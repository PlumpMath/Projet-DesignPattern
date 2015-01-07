using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{

	public class DeplacementFou : ComportementSeDeplacerJE
	{
		
		public DeplacementFou ()
		{
			this.déplacements = new int[,]{ {2,4}, {2,6}, {8,4}, {8,6} };
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

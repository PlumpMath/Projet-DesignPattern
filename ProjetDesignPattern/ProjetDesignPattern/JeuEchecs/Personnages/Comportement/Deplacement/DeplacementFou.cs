using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementFou : ComportementSeDeplacerJE
	{
		public DeplacementFou ()
		{
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


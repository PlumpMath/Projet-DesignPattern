using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementPion : ComportementSeDeplacerJE
	{
		public DeplacementPion ()
		{
			this.déplacements = new int[,] { {1} };
			this.déplacementInfinie = false;
		}

		public override void deplacer(ZoneAbstraite zone)
        {
			this.personnage.Position = zone;
        }

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone)
        {
			List<ZoneAbstraite> zones = new List<ZoneAbstraite> ();
			if (zone.zonesAdjacentes.ContainsKey (8)) {
				zones.Add (zone.zonesAdjacentes [8]);
			}
			return zones;
        }
    }
}


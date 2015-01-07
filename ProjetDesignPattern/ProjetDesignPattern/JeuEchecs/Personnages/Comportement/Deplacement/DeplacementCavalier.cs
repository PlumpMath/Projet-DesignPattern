using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementCavalier : ComportementSeDeplacerJE
	{
		public DeplacementCavalier ()
		{
			this.déplacements = new int[,] { {2,2,4}, {2,2,6}, {4,4,2}, {4,4,8}, {6,6,2}, {6,6,8}, {8,8,4}, {8,8,6} };
			this.déplacementInfinie = false;
		}

		public override void deplacer(ZoneAbstraite zone)
        {
            throw new NotImplementedException();
        }

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone)
		{
			List<ZoneAbstraite> zones = new List<ZoneAbstraite> ();

			ZoneAbstraite tmp = getIndicateur (zone, 8);
			addZone (zones, tmp, 4, 6);

			tmp = getIndicateur (zone, 6);
			addZone (zones, tmp, 8, 2);

			tmp = getIndicateur (zone, 2);
			addZone (zones, tmp, 4, 6);

			tmp = getIndicateur (zone, 4);
			addZone (zones, tmp, 8, 2);

			return zones;
        }

		private ZoneAbstraite getIndicateur(ZoneAbstraite zone, int direction){
			ZoneAbstraite end = null;
			if (zone.zonesAdjacentes.ContainsKey (direction)) {
				zone = zone.zonesAdjacentes [direction];
				if (zone.zonesAdjacentes.ContainsKey (direction)) {
					end = zone.zonesAdjacentes [direction];
				}
			}
			return end;
		}
		private void addZone(List<ZoneAbstraite> zones, ZoneAbstraite zone, int d1, int d2){
			if (zone != null) {
				if (zone.zonesAdjacentes.ContainsKey (d1)) {
					zones.Add(zone.zonesAdjacentes[d1]);
				}
				if (zone.zonesAdjacentes.ContainsKey (d2)) {
					zones.Add(zone.zonesAdjacentes[d2]);
				}
			}
		}
    }
}


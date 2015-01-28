using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public abstract class ComportementSeDeplacerJE : ComportementSeDeplacerAbstrait
    {
		public int[][] déplacements;
		public bool déplacementInfinie;

		public override void deplacer(ZoneAbstraite zone){
			this.personnage.Position = zone;
		}

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone){
			List<ZoneAbstraite> zones = new List<ZoneAbstraite> ();
			initDéplacement (zones, zone);
			return zones;
		}

		private void initDéplacement(List<ZoneAbstraite> zones, ZoneAbstraite zone){
			for (int i = 0; i < déplacements.Length; i++){
				ZoneAbstraite tmp = accessible (zone, déplacements [i]);
				if (tmp != null && !zones.Contains(tmp)) {
					zones.Add (tmp);
					if (déplacementInfinie) {
						initDéplacement (zones, tmp);
					}
				}
			}
		}

		public virtual ZoneAbstraite accessible(ZoneAbstraite zone, int[] a){
			for (int index = 0; index < a.Length; index++) {
				if (!zone.zonesAdjacentes.ContainsKey(a[index]))
					return null;
				if(zone.zonesAdjacentes[a[index]].accès)
					return zone.zonesAdjacentes[a[index]].arrivée;
			}
			return null;
		}
    }
}

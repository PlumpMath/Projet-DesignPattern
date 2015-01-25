using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementPion : ComportementSeDeplacerJE
	{
		public DeplacementPion ()
		{
			this.déplacements = new int[][] { new int[] {7}, new int[] {8}, new int[] {9} };
			this.déplacementInfinie = false;

		}

		public override ZoneAbstraite accessible(ZoneAbstraite zone, int[] a){
			if (!zone.zonesAdjacentes.ContainsKey (a [0])) {
				if (a [0] == 8) {
					return zone.zonesAdjacentes [8].arrivée;
				} else {
					zone = zone.zonesAdjacentes [a [0]].arrivée;
					if(zone.listePersonnages.Count > 0){
						return zone;
					}
				}		
			}
			return null;
		}
    }
}


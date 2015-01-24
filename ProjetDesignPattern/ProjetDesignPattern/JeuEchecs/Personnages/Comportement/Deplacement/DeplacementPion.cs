using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementPion : ComportementSeDeplacerJE
	{
		public DeplacementPion ()
		{
			this.déplacements = new int[][] { {7}, {8}, {9} };
			this.déplacementInfinie = false;
		}

		public override ZoneAbstraite accessible(ZoneAbstraite zone, int[] a){
			if (!zone.zonesAdjacentes.ContainsKey (a [0])) {
				if (a [0] == 8) {
					return zone.zonesAdjacentes [8];
				} else {
					zone = zone.zonesAdjacentes [a [0]];
					if(zone.listePersonnages.Count > 0){
						return zone;
					}
				}
				return null;			
			}
		}
    }
}


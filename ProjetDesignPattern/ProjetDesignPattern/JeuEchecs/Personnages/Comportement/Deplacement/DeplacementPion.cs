using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementPion : ComportementSeDeplacerJE
	{
		private bool firstDéplacement = true;
		private bool type;
		public DeplacementPion (bool type)
		{
			this.type = type;
			if (type)
				this.déplacements = new int[][] { new int[] {8,4}, new int[] {8}, new int[] {8,6}, new int[] {8, 8} };
			else
				this.déplacements = new int[][] { new int[] {2,4}, new int[] {2}, new int[] {2,6}, new int[] {2, 2} };
			this.déplacementInfinie = false;
			this.déplacementLibre = false;

		}

		public override void deplacer(ZoneAbstraite zone){
			base.deplacer (zone);
			if (firstDéplacement) {
				if (type)
					this.déplacements = new int[][] { new int[] {8,4}, new int[] {8}, new int[] {8,6}};
				else
					this.déplacements = new int[][] { new int[] {2,4}, new int[] {2}, new int[] {2,3}};
				firstDéplacement = false;
			}
		}

		public override ZoneAbstraite accessible(ZoneAbstraite zone, int[] a){
			ZoneAbstraite tmp = zone;
			char color = this.personnage.Nom [0];
			if (tmp.zonesAdjacentes.ContainsKey (a [0])) {
				tmp = tmp.zonesAdjacentes [a[0]].arrivée;
				if (a.Length == 1) {
					if (tmp.listePersonnages.Count == 0) {
						return tmp;
					}
					if (tmp.listePersonnages [0].Nom [0] != color) {
						return tmp;
					}
				} else {
					if (tmp.zonesAdjacentes.ContainsKey (a [1])) {
						if (a [1] == 8 || a [1] == 2) {
							if (tmp.listePersonnages.Count == 0) {
								tmp = tmp.zonesAdjacentes [a [1]].arrivée;
								if (tmp.listePersonnages.Count == 0) {
									return tmp;
								}
								if (tmp.listePersonnages [0].Nom [0] != color) {
									return tmp;
								}
							}
						} else {
							tmp = tmp.zonesAdjacentes [a [1]].arrivée;
							if (tmp.listePersonnages.Count > 0 && tmp.listePersonnages [0].Nom [0] != color) {
								return tmp;
							}
						}
					}
				}
			}
			return null;
		}
	}
}

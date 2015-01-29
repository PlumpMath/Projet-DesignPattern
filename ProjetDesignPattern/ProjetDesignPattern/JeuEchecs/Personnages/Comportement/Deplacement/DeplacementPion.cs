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
				this.déplacements = new int[][] { new int[] {2,4}, new int[] {2}, new int[] {2,3}, new int[] {2, 2} };
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
			for (int index = 0; index < a.Length; index++) {
				if (!tmp.zonesAdjacentes.ContainsKey (a [index]))
					return null;
				else if (tmp.zonesAdjacentes [a [index]].accès)
					tmp = tmp.zonesAdjacentes [a [index]].arrivée;
				else
					return null;
			}
			if (a.Length == 2 &&  (a[1] == 8 || a[1] == 2)) {
				return tmp;
			}
			if (a.Length > 1 && tmp.listePersonnages.Count > 0) {
				return tmp;
			} else if (a.Length == 1) {
				return tmp;
			}
			return null;

		}
    }
}


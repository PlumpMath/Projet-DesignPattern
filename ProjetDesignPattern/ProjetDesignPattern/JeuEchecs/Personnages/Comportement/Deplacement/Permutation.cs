using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class Permutation
	{
		private bool breakLoop, infinie;
		private List<ZoneAbstraite> zones;
		private ZoneAbstraite zone;

		public Permutation (List<ZoneAbstraite> zones, ZoneAbstraite zone, bool infinie)
		{
			this.zones = zones;
			this.zone = zone;
			this.infinie = infinie;
			breakLoop = false;
		}
		private void perm(int[] s, int n, int i){
			if (i >= n - 1) {
				ZoneAbstraite tmp = compare (zone, s);
				if (!infinie) {
					if (tmp != null) {
						zones.Add (tmp);
						breakLoop = true;
					}
				} else {
					if (tmp != null) {
						zones.Add (tmp);
						breakLoop = true;
					}
				}
			} else if(!breakLoop){
				perm(s, n, i+1);
				for (int j = i+1; j<n; j++){
					swap(s, i, j);
					perm(s, n, i+1);
					swap(s, i, j);
				}
			}
		}
		private int[] swap(int[] s, int i , int j){
			int tmp = s [i];
			s [i] = s [j];
			s [j] = tmp;
			return s;
		}
		private ZoneAbstraite compare(ZoneAbstraite zone, int[] a){
			for (int index = 0; index < a.Length; index++) {
				if (!zone.zonesAdjacentes.ContainsKey(a[index]))
					return null;
				zone = zone.zonesAdjacentes[a[index]];
			}
			return zone;
		}
	}
}


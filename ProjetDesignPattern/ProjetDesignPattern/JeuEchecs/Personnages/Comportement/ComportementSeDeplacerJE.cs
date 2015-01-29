﻿using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public abstract class ComportementSeDeplacerJE : ComportementSeDeplacerAbstrait
    {
		public int[][] déplacements;
		public bool déplacementInfinie, déplacementLibre;

		public override void deplacer(ZoneAbstraite zone){
			this.personnage.Position.listePersonnages.RemoveAt(0);
			this.personnage.Position = zone;
			if (zone != null) {
				zone.listePersonnages.Add (this.personnage);
			}
		}

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone){
			List<ZoneAbstraite> zones = new List<ZoneAbstraite> ();
			initDéplacement (zones, zone);
			Console.WriteLine ("Nombre de zone accessible " + zones.Count);
			return zones;
		}

		private void initDéplacement(List<ZoneAbstraite> zones, ZoneAbstraite zone){
			Console.WriteLine (déplacements.Length);
			for (int i = 0; i < déplacements.Length; i++){
				Console.Write (déplacements[i].ToString() + " ");
				ZoneAbstraite tmp = accessible (zone, déplacements [i]);
				if (tmp != null && !containsZone (zones, tmp)) {
					Console.WriteLine ("accessible");
					ajoutDéplacement (zones, tmp);
					if (déplacementInfinie) {
						initDéplacement (zones, tmp, déplacements [i]);
					}
				} else {
					tmp = accessibleWithEnemi (zone, déplacements [i]);
					if (tmp != null) {
						ajoutDéplacement (zones, tmp);
					}
				}
			}
		}

		private void initDéplacement(List<ZoneAbstraite> zones, ZoneAbstraite zone, int[] direction){
			ZoneAbstraite tmp = accessible (zone, direction);
			if (tmp != null && !containsZone (zones, tmp)) {
				ajoutDéplacement (zones, tmp);
				initDéplacement (zones, tmp, direction);
			} else {
				tmp = accessibleWithEnemi (zone, direction);
				if (tmp != null) {
					ajoutDéplacement (zones, tmp);
				}
			}
		}

		public virtual ZoneAbstraite accessible(ZoneAbstraite zone, int[] a){
			ZoneAbstraite tmp = zone;
			for (int index = 0; index < a.Length; index++) {
				if (!tmp.zonesAdjacentes.ContainsKey (a [index]))
					return null;
				else if (tmp.zonesAdjacentes [a [index]].accès)
					tmp = tmp.zonesAdjacentes [a [index]].arrivée;
				else
					return null;
			}
			if (!déplacementLibre && tmp.listePersonnages.Count > 0) {
				return null;
			}
			return tmp;
		}

		public ZoneAbstraite accessibleWithEnemi(ZoneAbstraite zone, int[] a){
			ZoneAbstraite tmp = zone;
			for (int index = 0; index < a.Length; index++) {
				if (!tmp.zonesAdjacentes.ContainsKey (a [index]))
					return null;
				else if (tmp.zonesAdjacentes [a [index]].accès)
					tmp = tmp.zonesAdjacentes [a [index]].arrivée;
				else
					return null;
			}
			if (tmp.listePersonnages.Count > 0) {
				return tmp;
			}
			return null;
		}

		private bool containsZone(List<ZoneAbstraite> zones, ZoneAbstraite zone){
			for (int i = 0; i < zones.Count; i++) {
				if (zones [i].positionX == zone.positionX &&
					zones [i].positionY == zone.positionY)
					return true;
			}
			return false;
		}
		private void ajoutDéplacement(List<ZoneAbstraite> zones, ZoneAbstraite zone){
			if (!(zone.listePersonnages.Count > 0 &&
				zone.listePersonnages [0].Nom [0] == this.personnage.Nom [0]))
				zones.Add (zone);
		}
    }
}

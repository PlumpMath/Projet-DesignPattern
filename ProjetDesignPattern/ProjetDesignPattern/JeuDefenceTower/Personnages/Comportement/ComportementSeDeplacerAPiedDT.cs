using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuDefenceTower
{
    public class ComportementSeDeplacerAPiedDT : ComportementSeDeplacerAbstrait
    {
		public override void deplacer(ZoneAbstraite zone){
            personnage.Position.listePersonnages.Remove(personnage);
            personnage.Position = zone;
            zone.listePersonnages.Add(personnage);

			//TODO Mettre dans les log
			//"se déplace vers l'avant";
		}

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone){
            List<ZoneAbstraite> listeZones = new List<ZoneAbstraite>();
            foreach (KeyValuePair<int, AccesAbstrait> pair in zone.zonesAdjacentes)
            {
                listeZones.Add(pair.Value.arrivée);
            }
            return listeZones;
		}
    }
}

using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    class ComportementSeDeplacerVoiture : ComportementSeDeplacerAbstrait
    {

		public override void deplacer(ZoneAbstraite zone)
        {
            personnage.Position.listePersonnages.Remove(personnage);
            personnage.Position = zone;
            zone.listePersonnages.Add(personnage);
		}

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone)
        {
            List<ZoneAbstraite> listeZones = new List<ZoneAbstraite>();
            foreach(KeyValuePair<int,AccesAbstrait> pair in zone.zonesAdjacentes)
            {
                listeZones.Add(pair.Value.arrivée);
            }
            return listeZones;
		}
    }
}

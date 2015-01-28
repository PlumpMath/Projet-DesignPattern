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
                List<PersonnageAbstrait> persos = pair.Value.arrivée.listePersonnages;
                bool emplacementLibre = true;
                foreach(PersonnageAbstrait p in persos){
                    if (p.GetType() != typeof(FeuSignalisation))
                    {
                        emplacementLibre = false;
                    }
                    else
                    {
                        emplacementLibre = ((FeuSignalisation)p).Etat == FeuSignalisation.vert;
                    }
                }
                if (emplacementLibre)
                    listeZones.Add(pair.Value.arrivée);
            }
            return listeZones;
		}
    }
}

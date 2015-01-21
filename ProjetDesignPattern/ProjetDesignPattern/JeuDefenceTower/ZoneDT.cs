using System;
using System.Collections.Generic;
namespace ProjetDesignPattern.JeuDefenceTower
{
    class ZoneDT : ZoneAbstraite
    {
        public string nomImageZone { get; set; }

        public ZoneDT()
        {        
            listePersonnages = new List<PersonnageAbstrait>();
		    zonesAdjacentes = new Dictionary<int, AccesAbstrait>();
            positionX = 0;
            positionY = 0;
        }

        public void créerZoneDT(int _x, int _y)
        {
            positionX = _x;
            positionY = _y;
            nomImageZone = "z" + _x + _y;
        }

        public void attacherEnnemi(Ennemi e)
        {
            listePersonnages.Add(e);
        }

        public void enleverEnnemi(Ennemi e)
        {
            listePersonnages.Remove(e);
        }

        public bool jeSuisArrivéAuChateau()
        {
            List<ZoneAbstraite> listeZones = new List<ZoneAbstraite>();
            foreach (KeyValuePair<int, AccesAbstrait> pair in this.zonesAdjacentes)
            {
                listeZones.Add(pair.Value.arrivée);
            }

            ZoneDT prochaineZone = (ZoneDT)listeZones[0];
            if (prochaineZone.nomImageZone == "chateau")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool laZoneDapresEstLibre()
        {
            List<ZoneAbstraite> listeZones = new List<ZoneAbstraite>();
            foreach (KeyValuePair<int, AccesAbstrait> pair in this.zonesAdjacentes)
            {
                listeZones.Add(pair.Value.arrivée);
            }

            ZoneDT prochaineZone = (ZoneDT)listeZones[0];
            if (prochaineZone.listePersonnages.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

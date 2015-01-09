using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    class ComportementSeDeplacerVoiture : ComportementSeDeplacerAbstrait
    {

		public override void deplacer(ZoneAbstraite zone)
        {
            personnage.Position = zone;
		}

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone){
            return null;
		}
    }
}

using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    class ComportementSeDeplacerVoiture : ComportementSeDeplacerAbstrait
    {

		public override void deplacer(ZoneAbstraite zone)
        {
            throw new NotImplementedException();
		}

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone){
			throw new NotImplementedException ();
		}
    }
}

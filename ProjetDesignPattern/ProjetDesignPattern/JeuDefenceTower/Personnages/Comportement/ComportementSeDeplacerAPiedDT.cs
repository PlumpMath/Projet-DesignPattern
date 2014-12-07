using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuDefenceTower
{
    public class ComportementSeDeplacerAPiedDT : ComportementSeDeplacerAbstrait
    {
		public override void deplacer(ZoneAbstraite zone){
			//TODO Mettre dans les log
			//"se déplace vers l'avant";
		}

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone){
			throw new NotImplementedException ();
		}
    }
}

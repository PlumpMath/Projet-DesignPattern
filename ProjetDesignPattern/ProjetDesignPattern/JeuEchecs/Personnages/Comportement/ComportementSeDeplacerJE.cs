using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public abstract class ComportementSeDeplacerJE : ComportementSeDeplacerAbstrait
    {
		Case actuelle { get; set;}

		public override void deplacer(ZoneAbstraite zone){

		}

		public override List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone){
			throw new NotImplementedException ();
		}


    }
}

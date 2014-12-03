using System;
using System.Collections.Generic;

namespace ProjetDesignPattern
{
    public abstract class ComportementSeDeplacerAbstrait
	{
		public PersonnageAbstrait personnage { get; set;}

		public abstract void deplacer(ZoneAbstraite zone);

		public abstract List<ZoneAbstraite> déplacementPossible(ZoneAbstraite zone);
    }
}

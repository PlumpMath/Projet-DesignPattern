using System;

namespace ProjetDesignPattern
{
    public abstract class ComportementSeDeplacerAbstrait
	{
		public PersonnageAbstrait personnage { get; set;}

        public abstract void deplacer(ZoneAbstraite zone);
    }
}

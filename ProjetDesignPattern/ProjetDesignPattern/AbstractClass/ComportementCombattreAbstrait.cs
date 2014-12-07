using System;

namespace ProjetDesignPattern
{
    public abstract class ComportementCombattreAbstrait 
    {
		public int attaque { get; set;}

        public abstract void combattre(int degat, PersonnageAbstrait cible);
    }
}

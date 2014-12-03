using System;

namespace ProjetDesignPattern
{
    public abstract class ComportementCombattreAbstrait 
    {
        public ComportementCombattreAbstrait() 
        {
            
        }

        public abstract string combattre(int degat, PersonnageAbstrait cible);
    }
}

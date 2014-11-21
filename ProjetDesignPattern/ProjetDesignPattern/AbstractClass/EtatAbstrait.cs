using System;

namespace ProjetDesignPattern
{
    public abstract class EtatAbstrait
    {
        public PersonnageAbstrait personnage;

        public EtatAbstrait(PersonnageAbstrait unPersonnage)
        {
            personnage = unPersonnage;
        }

        public EtatAbstrait()
        {
        }
    }
}

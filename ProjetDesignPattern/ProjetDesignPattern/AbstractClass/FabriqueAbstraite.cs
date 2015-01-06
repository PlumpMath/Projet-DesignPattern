using System;

namespace ProjetDesignPattern
{
    public abstract class FabriqueAbstraite
    {
        public abstract PersonnageAbstrait CreerPersonnage(int typePerso, SujetObserveAbstrait unEtatMajor, string unNom);

        public abstract ZoneAbstraite CreerZone();

        public abstract AccesAbstrait CreerAcces();
    }
}

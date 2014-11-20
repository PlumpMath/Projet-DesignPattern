using System;

namespace ProjetDesignPattern
{
    public abstract class FabriqueAbstraite
    {
        public enum eTypePersonnage { };

        public abstract PersonnageAbstrait CreerPersonnage(FabriqueAbstraite.eTypePersonnage typePerso, SujetObserveAbstrait unEtatMajor, string unNom)
        {
            return null;
        }

        public abstract ZoneAbstraite CreerZone()
        {
            return null;
        }

        public abstract AccesAbstrait CreerAcces()
        {
            return null;
        }
    }
}

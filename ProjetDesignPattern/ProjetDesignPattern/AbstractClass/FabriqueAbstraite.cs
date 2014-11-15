using System;

namespace ProjetDesignPattern
{
    public abstract class FabriqueAbstraite
    {
        public enum eTypePersonnage { };

        public PersonnageAbstrait CreerPersonnage(FabriqueAbstraite.eTypePersonnage typePerso, SujetObserveAbstrait unEtatMajor, string unNom)
        {
            return null;
        }

        public ZoneAbstraite CreerZone()
        {
            return null;
        }

        public AccesAbstrait CreerAcces()
        {
            return null;
        }
    }
}

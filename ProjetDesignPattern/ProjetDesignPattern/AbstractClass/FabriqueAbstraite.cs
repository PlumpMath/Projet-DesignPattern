using System;

namespace ProjetDesignPattern
{
    public abstract class FabriqueAbstraite
    {
        public enum eTypePersonnage { };

        public abstract PersonnageAbstrait CreerPersonnage(FabriqueAbstraite.eTypePersonnage typePerso, SujetObserveAbstrait unEtatMajor, string unNom);

        public abstract ZoneAbstraite CreerZone();

        public abstract AccesAbstrait CreerAcces();
    }
}

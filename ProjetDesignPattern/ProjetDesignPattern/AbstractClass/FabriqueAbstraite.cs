using System;

namespace ProjetDesignPattern
{
    public abstract class FabriqueAbstraite
    {
        public abstract PersonnageAbstrait CreerPersonnage(int typePerso, SujetObserveAbstrait unEtatMajor, string unNom, ZoneAbstraite unePosition);

        public abstract ZoneAbstraite CreerZone();

        public abstract AccesAbstrait CreerAcces(ZoneAbstraite départ, ZoneAbstraite arrivée);

    }
}

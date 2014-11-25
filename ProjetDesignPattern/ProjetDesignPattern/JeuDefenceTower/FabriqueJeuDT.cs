using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    class FabriqueJeuDT : FabriqueAbstraite
    {
        public abstract override PersonnageAbstrait CreerPersonnage(FabriqueAbstraite.eTypePersonnage typePerso, SujetObserveAbstrait unEtatMajor, string unNom)
        {
            throw new NotImplementedException();
        }

        public abstract override ZoneAbstraite CreerZone()
        {
            throw new NotImplementedException();
        }

        public abstract override AccesAbstrait CreerAcces()
        {
            throw new NotImplementedException();
        }
    }
}

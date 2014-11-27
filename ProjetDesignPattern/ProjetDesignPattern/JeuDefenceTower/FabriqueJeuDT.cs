using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    class FabriqueJeuDT : FabriqueAbstraite
    {
        public override PersonnageAbstrait CreerPersonnage(FabriqueAbstraite.eTypePersonnage typePerso, SujetObserveAbstrait unEtatMajor, string unNom)
        {
            throw new NotImplementedException();
        }

        public override ZoneAbstraite CreerZone()
        {
            throw new NotImplementedException();
        }

        public override AccesAbstrait CreerAcces()
        {
            throw new NotImplementedException();
        }
    }
}

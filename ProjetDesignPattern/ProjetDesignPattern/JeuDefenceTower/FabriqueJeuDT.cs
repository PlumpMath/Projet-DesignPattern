using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    class FabriqueJeuDT : FabriqueAbstraite
    {
        public override PersonnageAbstrait CreerPersonnage(int typePerso, SujetObserveAbstrait unEtatMajor, string unNom, ZoneAbstraite unePosition)
        {
            throw new NotImplementedException();
        }

        public override ZoneAbstraite CreerZone()
        {
            throw new NotImplementedException();
        }

        public override AccesAbstrait CreerAcces(ZoneAbstraite départ, ZoneAbstraite arrivée)
        {
            throw new NotImplementedException();
        }
    }
}

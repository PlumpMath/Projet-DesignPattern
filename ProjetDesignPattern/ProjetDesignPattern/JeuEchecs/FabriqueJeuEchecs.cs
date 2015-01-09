using System;

namespace ProjetDesignPattern.JeuEchecs
{
    class FabriqueJeuEchecs : FabriqueAbstraite
    {

        public override PersonnageAbstrait CreerPersonnage(int typePerso, SujetObserveAbstrait unEtatMajor, string unNom)
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

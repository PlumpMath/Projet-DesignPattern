using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

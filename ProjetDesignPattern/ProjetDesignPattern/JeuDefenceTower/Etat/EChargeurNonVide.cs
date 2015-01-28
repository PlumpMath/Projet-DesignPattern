using System;

namespace ProjetDesignPattern.JeuDefenceTower.Etat
{
    class EChargeurNonVide : EtatAbstraitDT
    {
        
        public EChargeurNonVide(Chateau c) : base(c) { }

        public override int Tirer()
        {
            if (chateau.nbBallesCourant > 0)
            {
                chateau.nbBallesCourant--;
                return (chateau.ptAttaque);
            }
            else
            {
                chateau.etatTir = new ERechargement(chateau);
                return (0);
            }
        }

        public override int AttaqueSpecialePlusDégat()
        {
            if (chateau.nbBallesCourant > 0)
            {
                chateau.nbBallesCourant--;
                chateau.etatTir = new EPlusDégat(chateau);
                return (chateau.ptAttaque*2);
            }
            else
            {
                chateau.etatTir = new ERechargement(chateau);
                return (0);
            }
        }

    }
}

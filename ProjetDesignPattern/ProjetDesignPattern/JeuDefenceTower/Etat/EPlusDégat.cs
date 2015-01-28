using System;

namespace ProjetDesignPattern.JeuDefenceTower.Etat
{
    class EPlusDégat : EtatAbstraitDT
    {
        public EPlusDégat(Chateau c) : base(c) { }

        public override int Tirer()
        {
            if (chateau.nbBallesCourant > 0)
            {
                chateau.nbBallesCourant--;
                return (chateau.ptAttaque * 2);
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
                return (chateau.ptAttaque * 2);
            }
            else
            {
                chateau.etatTir = new ERechargement(chateau);
                return (0);
            }
        }

    }
}

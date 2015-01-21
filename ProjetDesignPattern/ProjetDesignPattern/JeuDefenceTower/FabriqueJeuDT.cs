using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    class FabriqueJeuDT : FabriqueAbstraite
    {
        public const int typeChateau = 1;
        public const int typeEnnemi = 2;

        public override PersonnageAbstrait CreerPersonnage(int typePerso, SujetObserveAbstrait unEtatMajor, string unNom, ZoneAbstraite unePosition)
        {
            //château
            if (typePerso == 1)
            {
                Chateau c = new Chateau(unNom);
                return c;
            }
            //ennemi
            else
            {
                Ennemi e = new Ennemi(unNom,unePosition);
                return e;
            }
        }

        public override ZoneAbstraite CreerZone()
        {
            return new ZoneDT();
        }

        public override AccesAbstrait CreerAcces(ZoneAbstraite départ, ZoneAbstraite arrivée)
        {
            AccesAbstrait acces = new AccesDT();
            acces.départ = départ;
            acces.arrivée = arrivée;

            //Ajout de l'accès à la zone départ
            départ.zonesAdjacentes.Add(1, acces);

            return acces;
        }
    }
}

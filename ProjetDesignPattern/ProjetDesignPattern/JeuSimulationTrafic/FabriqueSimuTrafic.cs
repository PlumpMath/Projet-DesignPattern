
using System.Collections.Generic;
namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public class FabriqueSimuTrafic : FabriqueAbstraite
    {
        public const int typeFeu = 0;
        public const int typeCamion = 1;
        public const int typeVoiture = 2;
        public const int typeMoto = 3;

        public override PersonnageAbstrait CreerPersonnage(int typePerso, SujetObserveAbstrait unEtatMajor, string unNom, ZoneAbstraite unePosition)
        {
            PersonnageAbstrait perso;
            switch(typePerso){
                case typeCamion:
                    perso = new Camion();
                    break;
                case typeVoiture:
                    perso =  new Voiture();
                    perso.comportementSeDeplacer = new ComportementSeDeplacerVoiture();
                    perso.comportementSeDeplacer.personnage = perso;
                    break;
                case typeMoto:
                default:
                    perso = new Moto();
                    break;
            }
            perso.Nom = unNom;
            perso.Position = unePosition;
            unePosition.listePersonnages.Add(perso);

            if(unEtatMajor != null)
                unEtatMajor.AjouterObservateur(perso);

            return perso;
        }

        public SujetObserveAbstrait CreerSujetObserve()
        {
            SujetObserveAbstrait feu = new FeuSignalisation();

            return feu;
        }

        public override ZoneAbstraite CreerZone()
        {
            ZoneAbstraite zone = new PortionDeRoute();
            zone.listePersonnages = new List<PersonnageAbstrait>();
            zone.listeObjets = new List<ObjetAbstrait>();
            zone.zonesAdjacentes = new Dictionary<int, AccesAbstrait>();

            return zone;
        }

        public override AccesAbstrait CreerAcces(ZoneAbstraite départ, ZoneAbstraite arrivée)
        {
            AccesAbstrait acces = new AccesRoute();
            acces.départ = départ;
            acces.arrivée = arrivée;

            //Ajout de l'accès à la zone départ
            départ.zonesAdjacentes.Add(1, acces);

            return acces;
        }
    }
}

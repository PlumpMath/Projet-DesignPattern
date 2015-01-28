
using System.Collections.Generic;
namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public class FabriqueSimuTrafic : FabriqueAbstraite
    {
        public const int typeFeu = 0;
        public const int typeCamion = 1;
        public const int typeVoiture = 2;
        public const int typeMoto = 3;
        
        public override PersonnageAbstrait CreerPersonnage(int _id, string _type, string _nom, string _pv, 
            string _etat, ZoneAbstraite _position, SujetObserveAbstrait EtatMajor)
        {
            PersonnageAbstrait perso;
            switch (_type)
            {
                case "camion":
                    perso = new Camion();
                    break;
                case "feu":
                    perso = new FeuSignalisation();
                    break;
                case "voiture":
                    perso =  new Voiture();
                    perso.comportementSeDeplacer = new ComportementSeDeplacerVoiture();
                    perso.comportementSeDeplacer.personnage = perso;
                    break;
                case "moto":
                default:
                    perso = new Moto();
                    break;
            }
            perso.Nom = _nom;
            perso.Position = _position;
            _position.listePersonnages.Add(perso);

            if (EtatMajor != null)
            {
                EtatMajor.AjouterObservateur(perso);
                perso.EtatMajor = EtatMajor;
            }

            return perso;
        }

        public SujetObserveAbstrait CreerSujetObserve()
        {
            SujetObserveAbstrait feu = new FeuSignalisation();

            return feu;
        }

        public override ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets, int _positionX, int positionY)
        {
            ZoneAbstraite zone = new PortionDeRoute();
            zone.positionX = _positionX;
            zone.positionY = positionY;
            zone.listePersonnages = _listePersonnages;
            zone.listeObjets = _listeObjets;
            zone.zonesAdjacentes = new Dictionary<int, AccesAbstrait>();

            return zone;
        }


        public override AccesAbstrait CreerAcces(ZoneAbstraite _zoneDepart, ZoneAbstraite _zoneArrivee, bool _acces)
        {
            AccesAbstrait acces = new AccesRoute();
            acces.départ = _zoneDepart;
            acces.arrivée = _zoneArrivee;

            //Ajout de l'accès à la zone départ
            _zoneDepart.zonesAdjacentes.Add(1, acces);

            return acces;
        }

        public override ObjetAbstrait CreerObjet(string _nom, ZoneAbstraite _position)
        {
            throw new System.NotImplementedException();
        }
    }
}

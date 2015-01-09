
namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public class FabriqueSimuTrafic : FabriqueAbstraite
    {
        public const int typeCamion = 1;
        public const int typeVoiture = 2;
        public const int typeMoto = 3;

        public override PersonnageAbstrait CreerPersonnage(int typePerso, SujetObserveAbstrait unEtatMajor, string unNom)
        {
            switch(typePerso){
                case typeCamion:
                    Camion cam = new Camion();
                    cam.Nom = unNom;
                    return cam;
                case typeVoiture:
                    return new Voiture();
                case typeMoto:
                default:
                    return new Moto();
            }
        }

        public override ZoneAbstraite CreerZone()
        {
            return new PortionDeRoute();
        }

        public override AccesAbstrait CreerAcces()
        {
            return new AccesRoute();
        }
    }
}

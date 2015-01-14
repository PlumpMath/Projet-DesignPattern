
namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public class FabriqueSimuTrafic : FabriqueAbstraite
    {
        public const int typeCamion = 1;
        public const int typeVoiture = 2;
        public const int typeMoto = 3;

        public override PersonnageAbstrait CreerPersonnage(int typePerso, SujetObserveAbstrait unEtatMajor, string unNom)
        {
            PersonnageAbstrait perso;
            switch(typePerso){
                case typeCamion:
                    perso = new Camion();
                    break;
                case typeVoiture:
                    perso =  new Voiture();
                    break;
                case typeMoto:
                default:
                    perso = new Moto();
                    break;
            }
            perso.Nom = unNom;
            return perso;
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

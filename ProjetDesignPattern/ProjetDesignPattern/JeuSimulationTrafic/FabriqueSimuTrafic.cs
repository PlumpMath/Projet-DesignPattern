
namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public class FabriqueSimuTrafic : FabriqueAbstraite
    {
        enum eTypePersonnage
        {
            Camion,
            Voiture,
            Moto
        }

        public override PersonnageAbstrait CreerPersonnage(eTypePersonnage typePerso, SujetObserveAbstrait unEtatMajor, string unNom)
        {
            switch(typePerso){
                case eTypePersonnage.Camion:
                    return new Camion();
                case eTypePersonnage.Voiture:
                    return new Voiture();
                case eTypePersonnage.Moto:
                default:
                    return new Moto();
            }
        }

        public override ZoneAbstraite CreerZone()
        {
            throw new System.NotImplementedException();
        }

        public override AccesAbstrait CreerAcces()
        {
            throw new System.NotImplementedException();
        }
    }
}


namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public class FabriqueSimuTrafic : FabriqueAbstraite
    {

        public override PersonnageAbstrait CreerPersonnage(FabriqueAbstraite.eTypePersonnage typePerso, SujetObserveAbstrait unEtatMajor, string unNom)
        {
            throw new System.NotImplementedException();
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


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

		public override PersonnageAbstrait CreerPersonnage(string _type, string _nom,string _pv, string _etat, string zonePresent, SujetObserveAbstrait EtatMajor)
        {
            /*switch(typePerso){
                case eTypePersonnage.Camion:
                    return new Camion();
                case eTypePersonnage.Voiture:
                    return new Voiture();
                case eTypePersonnage.Moto:
                default:
                    return new Moto();
            }*/
			return null;
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

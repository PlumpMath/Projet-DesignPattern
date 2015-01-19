namespace ProjetDesignPattern.JeuSimulationTrafic
{
    class FeuSignalisation : SujetObserveAbstrait
    {

        public override void AnalyserSituation()
        {
            // Si autre feu est rouge et soi même vert
            // on doit passer rouge
        }

        public override void Execution()
        {
            // S'il doit passer au rouge
            // on passe rouge
            // on notifie les observateurs
        }

        public override void MiseAJour()
        {
            // Si autre feu est rouge, on passe au vert
        }
    }
}

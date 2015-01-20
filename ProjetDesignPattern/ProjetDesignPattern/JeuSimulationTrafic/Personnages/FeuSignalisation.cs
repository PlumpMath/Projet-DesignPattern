namespace ProjetDesignPattern.JeuSimulationTrafic
{
    class FeuSignalisation : SujetObserveAbstrait
    {
        public const int vert = 0;
        public const int rouge = 1;

        bool doitPasserAuRouge;

        public override void AnalyserSituation()
        {
            // Si autre feu est rouge et soi même vert
            // on doit passer rouge

            if (PV == 0)
            {
                PV = 10;
                doitPasserAuRouge = !doitPasserAuRouge;
            }
            else
            {
                PV--;
            }
        }

        public override void Execution()
        {
            // S'il doit passer au rouge
            // on passe rouge
            // on notifie les observateurs
            if (doitPasserAuRouge)
            {
                Etat = FeuSignalisation.rouge;
            }
            else
            {
                Etat = FeuSignalisation.vert;
            }
            Notifier();
        }

        public override void MiseAJour()
        {
            // Si autre feu est rouge, on passe au vert
        }
    }
}

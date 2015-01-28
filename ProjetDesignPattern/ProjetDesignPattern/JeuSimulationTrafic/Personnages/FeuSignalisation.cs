namespace ProjetDesignPattern.JeuSimulationTrafic
{
    class FeuSignalisation : SujetObserveAbstrait
    {
        public const int vert = 0;
        public const int rouge = 1;

        bool doitPasserAuRouge;

        public override void AnalyserSituation()
        {
            if (EtatMajor != null && EtatMajor.EtatMajor == null)
            {
                EtatMajor.EtatMajor = this;
                this.AjouterObservateur(EtatMajor);

            }

            if (Etat == FeuSignalisation.vert)
            {
                if (PV == 0)
                {
                    PV = 10;
                    doitPasserAuRouge = true;
                }
                PV--;
            }
        }

        public override void Execution()
        {
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
            if (EtatMajor.Etat == FeuSignalisation.vert)
            {
                doitPasserAuRouge = true;
            }
            else
            {
                doitPasserAuRouge = false;
            }
        }
    }
}

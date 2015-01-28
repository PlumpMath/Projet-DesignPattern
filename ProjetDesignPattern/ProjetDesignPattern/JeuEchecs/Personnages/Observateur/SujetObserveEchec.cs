using System;

namespace ProjetDesignPattern
{
	public class SujetObserveEchec : SujetObserveAbstrait
	{
		public SujetObserveEchec ()
		{
		}

        public override void AnalyserSituation()
        {
            throw new NotImplementedException();
        }

        public override void Execution()
        {
            throw new NotImplementedException();
        }

        public override void MiseAJour()
        {
            throw new NotImplementedException();
        }
    }
}


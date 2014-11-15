using System;
using System.Collections.Generic;

namespace ProjetDesignPattern
{
    public abstract class SujetObserveAbstrait
    {

        private List<ObservateurAbstrait> observateurList = new List<ObservateurAbstrait>();

        public void Attach(ObservateurAbstrait unObservateur)
        {
            observateurList.Add(unObservateur);
        }

        public void DeAttach(ObservateurAbstrait unObservateur)
        {
            observateurList.Remove(unObservateur);
        }

        public void Notify()
        {
            foreach (ObservateurAbstrait observateur in observateurList)
            {
                observateur.Update();
            }
        }
    }
}

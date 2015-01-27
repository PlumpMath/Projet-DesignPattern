using System;
using System.Collections.Generic;

namespace ProjetDesignPattern
{
    public abstract class SujetObserveAbstrait : PersonnageAbstrait
    {

		public List<ObservateurAbstrait> observateurList = new List<ObservateurAbstrait>();

        public void AjouterObservateur(ObservateurAbstrait unObservateur)
        {
            observateurList.Add(unObservateur);
        }

        public void EnleverObservateur(ObservateurAbstrait unObservateur)
        {
            observateurList.Remove(unObservateur);
        }

        public void Notifier()
        {
            foreach (ObservateurAbstrait observateur in observateurList)
            {
                observateur.MiseAJour();
            }
        }
    }
}

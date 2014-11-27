using System;

namespace ProjetDesignPattern.JeuDefenceTower.Etat
{
    class ERechargement : EtatAbstraitDT
    {
        public override void Tirer()
        {
            throw new NotImplementedException();
        }

        public override void PlusDeMunitions()
        {
            throw new NotImplementedException();
        }

        public override void FinRechargement()
        {
            throw new NotImplementedException();
        }

        public override void AttaqueSpecialePlusDégat()
        {
            throw new NotImplementedException();
        }

        public override void AttaqueSpecialePlusDeMunitions()
        {
            throw new NotImplementedException();
        }
    }
}

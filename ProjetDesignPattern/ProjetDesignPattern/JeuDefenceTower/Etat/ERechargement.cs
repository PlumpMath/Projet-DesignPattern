using System;
using System.Windows.Forms;

namespace ProjetDesignPattern.JeuDefenceTower.Etat
{
    class ERechargement : EtatAbstraitDT
    {
        public ERechargement(Chateau c) : base(c) { }

        public override int Tirer()
        {
            MessageBox.Show("Plus de balles");
            return 0;
        }

        public override int AttaqueSpecialePlusDégat()
        {
            MessageBox.Show("Plus de balles");
            return 0;
        }

    }
}

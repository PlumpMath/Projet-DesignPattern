using System;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    class ModuleIHM_Traffic : ModuleIHMAbstrait
    {
        IHM_Traffic ihm = new IHM_Traffic();

        public override void afficher()
        {
            foreach (PersonnageAbstrait perso in jeu.listePersonnages)
            {
                ihm.changeTexteBox(perso.Nom);
            }

            ihm.Show();
        }
    }
}

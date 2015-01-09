using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjetDesignPattern.JeuSimulationTrafic;

namespace ProjetDesignPattern
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Simulation jeu = new Simulation("Simulation traffic");
            jeu.fab = new FabriqueSimuTrafic();
            jeu.ModuleIHM = new ModuleIHM_Traffic();
            jeu.ModuleIHM.jeu = jeu;

            jeu.listePersonnages.Add(jeu.fab.CreerPersonnage(1, null, "voiture"));

            jeu.Afficher();
        }
    }
}

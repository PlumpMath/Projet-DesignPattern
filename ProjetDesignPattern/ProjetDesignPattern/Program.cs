using ProjetDesignPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetDesignPattern.JeuDefenceTower;


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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FenPrincipale());
            //ChargementJeu c = new ChargementJeu();
           
        }

        

        
		/*public static void Main (string[] args)
		{
			Simulation sim = new Simulation ("zea");

			//sim.chargerSimulation("Users/alexandredubois/workspace_C/CS/ProjetPattern/ProjetDesignPattern/ProjetDesignPattern/sauvegardes/structure_sauvegarde.xml");
			//sim.chargerSimulation (@"structure_sauvegarde.xml");
			sim.chargerSimulation (@"structure_sauvegardeSimulationTraffic.xml");

//"/Users/alexandredubois/workspace_C/CS/ProjetPattern/ProjetDesignPattern/ProjetDesignPattern/bin/Debug/sauvegardes/structure_sauvegarde.xml".
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}*/

        
    }
}

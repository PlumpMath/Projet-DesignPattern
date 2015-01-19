using ProjetDesignPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetDesignPattern.JeuDefenceTower;

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
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FenPrincipale());*/
            //ChargementJeu c = new ChargementJeu();
            Simulation simulation = new Simulation("Defense Tower");
            //simulation.jeuDT = new JeuDT();

            //personnages
            ZoneDT zone = new ZoneDT();
            zone.positionX = 1;
            zone.positionY = 1;
            ZoneDT zone2 = new ZoneDT();
            zone.positionX = 1;
            zone.positionY = 2;
            simulation.listeZones.Add(zone);
            simulation.listeZones.Add(zone2);
            Chateau c = new Chateau("chateau", 10, 5);
            Ennemi e = new Ennemi(10, "bob", 2, zone);
            e.chateau = c;
            simulation.listePersonnages.Add(e);
            

            int i = 0;
            while (i < 2)
            {
                simulation.TourDeJeu();
                MessageBox.Show(simulation.listePersonnages[0].Position.positionX.ToString());
                i++;
            }
        }
    }
}

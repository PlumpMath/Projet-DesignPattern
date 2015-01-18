using ProjetDesignPattern.JeuSimulationTrafic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDesignPattern
{
    public partial class FenPrincipale : Form
    {
        public FenPrincipale()
        {
            InitializeComponent();
        }

        private void FenPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Simulation jeu = new Simulation("Simulation traffic");
            jeu.fab = new FabriqueSimuTrafic();
            jeu.ModuleIHM = new ModuleIHM_Trafic();
            jeu.ModuleIHM.jeu = jeu;

            jeu.ModuleStats = new ModuleStats_Trafic();
            jeu.ModuleStats.jeu = jeu;
            
            ZoneAbstraite zone1 = jeu.fab.CreerZone();
            ZoneAbstraite zone2 = jeu.fab.CreerZone();
            ZoneAbstraite zone3 = jeu.fab.CreerZone();
            ZoneAbstraite zone4 = jeu.fab.CreerZone();

            jeu.fab.CreerAcces(zone1, zone2);
            jeu.fab.CreerAcces(zone2, zone3);
            jeu.fab.CreerAcces(zone3, zone4);
            jeu.fab.CreerAcces(zone4, zone1);

            jeu.listeZones.Add(zone1);
            jeu.listeZones.Add(zone2);
            jeu.listeZones.Add(zone3);
            jeu.listeZones.Add(zone4);

            PersonnageAbstrait voiture1 = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeVoiture, null, "voiture", zone1);
            jeu.listePersonnages.Add(voiture1);

            jeu.Afficher();

            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                jeu.TourDeJeu();
            }
        }
    }
}

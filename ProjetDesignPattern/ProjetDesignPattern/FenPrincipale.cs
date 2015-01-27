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

            /*Simulation jeu = new Simulation("Simulation traffic");
            jeu.fab = new FabriqueSimuTrafic();
            jeu.ModuleIHM = new ModuleIHM_Trafic();
            jeu.ModuleIHM.jeu = jeu;

            jeu.ModuleStats = new ModuleStats_Trafic();
            jeu.ModuleStats.jeu = jeu;
            
            ZoneAbstraite zone1 = jeu.fab.CreerZone();
            ZoneAbstraite zone2 = jeu.fab.CreerZone();
            ZoneAbstraite zone3 = jeu.fab.CreerZone();
            ZoneAbstraite zone4 = jeu.fab.CreerZone();
            ZoneAbstraite zone5 = jeu.fab.CreerZone();
            ZoneAbstraite zone6 = jeu.fab.CreerZone();
            ZoneAbstraite zone7 = jeu.fab.CreerZone();
            ZoneAbstraite zone8 = jeu.fab.CreerZone();

            jeu.fab.CreerAcces(zone1, zone2);
            jeu.fab.CreerAcces(zone2, zone3);
            jeu.fab.CreerAcces(zone3, zone4);
            jeu.fab.CreerAcces(zone4, zone5);
            jeu.fab.CreerAcces(zone5, zone6);
            jeu.fab.CreerAcces(zone6, zone7);
            jeu.fab.CreerAcces(zone7, zone8);
            jeu.fab.CreerAcces(zone8, zone1);

            jeu.listeZones.Add(zone1);
            jeu.listeZones.Add(zone2);
            jeu.listeZones.Add(zone3);
            jeu.listeZones.Add(zone4);
            jeu.listeZones.Add(zone5);
            jeu.listeZones.Add(zone6);
            jeu.listeZones.Add(zone7);
            jeu.listeZones.Add(zone8);

            PersonnageAbstrait feu = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeFeu, null, "Feu", zone3);
            PersonnageAbstrait voiture1 = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeVoiture, null, "voiture", zone1);
            PersonnageAbstrait voiture2 = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeVoiture, null, "voiture2", zone2);
            jeu.listePersonnages.Add(voiture1);
            jeu.listePersonnages.Add(voiture2);

            jeu.Afficher();

            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(500);
                jeu.TourDeJeu();
            }*/
        }
    }
}

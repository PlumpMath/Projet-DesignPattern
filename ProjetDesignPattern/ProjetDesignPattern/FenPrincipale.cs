using ProjetDesignPattern.JeuEchecs;
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
		private void button2_Click(object sender, EventArgs e)
		{
			Simulation jeu = new Simulation ("Simulation echec");
			jeu.fab = new FabriqueJeuEchecs ();
			jeu.ModuleIHM = new ModuleIHM_Echecs ();
			jeu.ModuleIHM.jeu = jeu;

			jeu.ModuleStats = new ModuleStats_Echecs ();
			jeu.ModuleStats.jeu = jeu;


			ZoneAbstraite[][] zones = new ZoneAbstraite [8][];

			for (int i = 0; i < 8; i++) {
				zones[i] = new ZoneAbstraite[8];
				for(int j = 0 ; j < 8 ; j++)
					zones[i][j] = jeu.fab.CreerZone();
			}

			for (int i = 0; i < 8; i++) {
				for (int j = 0; j < 8; j++) {
					if( i - 1 >= 0)
						jeu.fab.CreerAcces(zones[i][j], zones[i - 1][j]);
					if( i + 1 <= 7)
						jeu.fab.CreerAcces(zones[i][j], zones[i + 1][j]);
					if( j - 1 >= 0)
						jeu.fab.CreerAcces(zones[i][j], zones[i][j - 1]);
					if( j + 1 <= 7)
						jeu.fab.CreerAcces(zones[i][j], zones[i][j + 1]);
				}
			}
			for (int i = 0; i < 8; i++) 
				for (int j = 0; j < 8; j++) 
					jeu.listeZones.Add(zones[i][j]);
			int type, y;
			String color, piece;
			for (int i = 0; i < 2; i++) {
				if (i == 0) {
					color = "W";
					y = 0;
				} else {
					color = "B";
					y = 7;
				}
				for (int j = 0; j < 8; j++) {
					if (i == 0) {
						jeu.listePersonnages.Add(jeu.fab.CreerPersonnage (FabriqueJeuEchecs.typePion, null, "WP", zones [j] [1]));
					} else {
						jeu.listePersonnages.Add(jeu.fab.CreerPersonnage (FabriqueJeuEchecs.typePion, null, "BP", zones [j] [6]));
					}
					if (j == 0 || j == 7) {
						piece = "R";
						type = FabriqueJeuEchecs.typeTour;
					} else if(j == 1 || j == 6){
						piece = "C";
						type = FabriqueJeuEchecs.typeCavalier;
					} else if(j == 2 || j == 5){
						piece = "B";
						type = FabriqueJeuEchecs.typeFou;
					} else if(j == 3){
						piece = "K";
						type = FabriqueJeuEchecs.typeRoi;
					} else {
						piece = "Q";
						type = FabriqueJeuEchecs.typeReine;
					}
					jeu.listePersonnages.Add(jeu.fab.CreerPersonnage (type, null, color + piece, zones [j] [y]));
				}
			}
			jeu.Afficher ();
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

            for (int i = 0; i < 20; i++)
            {
                System.Threading.Thread.Sleep(500);
                jeu.TourDeJeu();
            }*/
        }

    }
}

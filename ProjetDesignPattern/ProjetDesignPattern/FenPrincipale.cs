using ProjetDesignPattern.JeuDefenceTower;
using ProjetDesignPattern.JeuEchecs;
using ProjetDesignPattern.JeuSimulationTrafic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ProjetDesignPattern
{
    public partial class FenPrincipale : Form
    {

        BackgroundWorker m_oWorker;
        Simulation jeu;
        OpenFileDialog openFileDialog1;
        string location_fileDialog;

        public FenPrincipale()
        {
            InitializeComponent();

            m_oWorker = new BackgroundWorker();
            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.ProgressChanged += new ProgressChangedEventHandler
                    (m_oWorker_ProgressChanged);
            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (m_oWorker_RunWorkerCompleted);
            m_oWorker.WorkerReportsProgress = true;
            m_oWorker.WorkerSupportsCancellation = true;

            openFileDialog1 = new OpenFileDialog();

            location_fileDialog = @"c:\";
            openFileDialog1.InitialDirectory = location_fileDialog;
        }

        private void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("C'est la fin du jeu");
            if (jeu.Nom == "JeuDefenceTower")
            {
                ((ModuleIHMDT)jeu.ModuleIHM).ihm.Close();
            }
            if (jeu.Nom == "JeuSimulationTrafic")
            {
                ((ModuleIHM_Trafic)jeu.ModuleIHM).ihm.Close();
            }
            if (jeu.Nom == "JeuEchecs")
            {
                ((ModuleIHM_Echecs)jeu.ModuleIHM).ihm.Close();
            }
        }

        private void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            jeu.Afficher();
        }

        private void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            while(true && !jeu.finDuJeu)
            {
                System.Threading.Thread.Sleep(jeu.vitesse);
                jeu.TourDeJeu();
                m_oWorker.ReportProgress(i);
                i++;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jeu = new Simulation("JeuDefenceTower", 1000);
            jeu.fab = new FabriqueJeuDT();
            jeu.ModuleIHM = new ModuleIHMDT(jeu);
            jeu.ModuleIHM.jeu = jeu;

            jeu.ModuleStats = new ModuleStat_DT();
            jeu.ModuleStats.jeu = jeu;
            
            ZoneDT zone1 = (ZoneDT)jeu.fab.CreerZone(1, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 0, 5);
            zone1.nomImageZone = "z05";
            ZoneDT zone2 = (ZoneDT)jeu.fab.CreerZone(2, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 1, 5);
            zone2.nomImageZone = "z15";
            ZoneDT zone3 = (ZoneDT)jeu.fab.CreerZone(3, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 2, 5);
            zone3.nomImageZone = "z25";
            ZoneDT zone4 = (ZoneDT)jeu.fab.CreerZone(4, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 3, 5);
            zone4.nomImageZone = "z35";
            ZoneDT zone5 = (ZoneDT)jeu.fab.CreerZone(5, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 4, 5);
            zone5.nomImageZone = "z45";
            ZoneDT zone6 = (ZoneDT)jeu.fab.CreerZone(6, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 5, 5);
            zone6.nomImageZone = "z55";
            ZoneDT zone7 = (ZoneDT)jeu.fab.CreerZone(7, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 6, 5);
            zone7.nomImageZone = "z65";
            ZoneDT zone8 = (ZoneDT)jeu.fab.CreerZone(8, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 7, 5);
            zone8.nomImageZone = "z75";
            ZoneDT zone9 = (ZoneDT)jeu.fab.CreerZone(9, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 8, 5);
            zone9.nomImageZone = "z85";
            ZoneDT zone10 = (ZoneDT)jeu.fab.CreerZone(10, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 9, 5);
            zone10.nomImageZone = "z95";

            //chateau
            ZoneDT zonechateau = (ZoneDT)jeu.fab.CreerZone(1, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 10, 5);
            zonechateau.nomImageZone = "chateau";

            jeu.fab.CreerAcces(zone1, zone2,false);
            jeu.fab.CreerAcces(zone2, zone3,false);
            jeu.fab.CreerAcces(zone3, zone4,false);
            jeu.fab.CreerAcces(zone4, zone5,false);
            jeu.fab.CreerAcces(zone5, zone6,false);
            jeu.fab.CreerAcces(zone6, zone7,false);
            jeu.fab.CreerAcces(zone7, zone8,false);
            jeu.fab.CreerAcces(zone8, zone9,false);
            jeu.fab.CreerAcces(zone9, zone10,false);

            //chateau
            jeu.fab.CreerAcces(zone10, zonechateau,false);

            jeu.listeZones.Add(zone1);
            jeu.listeZones.Add(zone2);
            jeu.listeZones.Add(zone3);
            jeu.listeZones.Add(zone4);
            jeu.listeZones.Add(zone5);
            jeu.listeZones.Add(zone6);
            jeu.listeZones.Add(zone7);
            jeu.listeZones.Add(zone8);
            jeu.listeZones.Add(zone9);
            jeu.listeZones.Add(zone10);
            //jeu.listeZones.Add(zonechateau);

            Chateau chateau = (Chateau)jeu.fab.CreerPersonnage(1, "chateau", "chateau","", "10", zonechateau,null);
            chateau.initChateau(10, 10,10,jeu);
            Ennemi ennemi = (Ennemi)jeu.fab.CreerPersonnage(2,"ennemi","ennemi1","","1", zone1,null);
            ennemi.initEnnemi(chateau, 10, 1);
            zone1.attacherEnnemi(ennemi);
            Ennemi ennemi2 = (Ennemi)jeu.fab.CreerPersonnage(3,"ennemi","ennemi2","","1", zone1,null);
            ennemi2.initEnnemi(chateau, 10, 1);
            zone1.attacherEnnemi(ennemi2);
            Ennemi ennemi3 = (Ennemi)jeu.fab.CreerPersonnage(4,"ennemi","ennemi3","","1", zone1,null);
            ennemi3.initEnnemi(chateau, 10, 1);
            zone1.attacherEnnemi(ennemi3);
            Ennemi ennemi4 = (Ennemi)jeu.fab.CreerPersonnage(5,"ennemi","ennemi4","","1", zone1,null);
            ennemi4.initEnnemi(chateau, 10, 1);
            zone1.attacherEnnemi(ennemi4);

            jeu.listePersonnages.Add(chateau);
            jeu.listePersonnages.Add(ennemi);
            jeu.listePersonnages.Add(ennemi2);
            jeu.listePersonnages.Add(ennemi3);
            jeu.listePersonnages.Add(ennemi4);

            m_oWorker.RunWorkerAsync();  

        }

        private void button3_Click(object sender, EventArgs e)
        {

            jeu = new Simulation("JeuSimulationTrafic", 250);
            jeu.fab = new FabriqueSimuTrafic();
            jeu.ModuleIHM = new ModuleIHM_Trafic(jeu);
            jeu.ModuleIHM.jeu = jeu;

            jeu.ModuleStats = new ModuleStats_Trafic();
            jeu.ModuleStats.jeu = jeu;

            ZoneAbstraite zone1 = jeu.fab.CreerZone(1, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 0, 0);
            ZoneAbstraite zone2 = jeu.fab.CreerZone(2, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 1, 0);
            ZoneAbstraite zone3 = jeu.fab.CreerZone(3, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 2, 0);
            ZoneAbstraite zone4 = jeu.fab.CreerZone(4, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 2, 1);
            ZoneAbstraite zone5 = jeu.fab.CreerZone(5, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 2, 2);
            ZoneAbstraite zone6 = jeu.fab.CreerZone(6, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 1, 2);
            ZoneAbstraite zone7 = jeu.fab.CreerZone(7, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 0, 2);
            ZoneAbstraite zone8 = jeu.fab.CreerZone(8, new List<PersonnageAbstrait>(), new List<ObjetAbstrait>(), 0, 1);
        

            jeu.fab.CreerAcces(zone1, zone2, true);
            jeu.fab.CreerAcces(zone2, zone3, true);
            jeu.fab.CreerAcces(zone3, zone4, true);
            jeu.fab.CreerAcces(zone4, zone5, true);
            jeu.fab.CreerAcces(zone5, zone6, true);
            jeu.fab.CreerAcces(zone6, zone7, true);
            jeu.fab.CreerAcces(zone7, zone8, true);
            jeu.fab.CreerAcces(zone8, zone1, true);

            jeu.listeZones.Add(zone1);
            jeu.listeZones.Add(zone2);
            jeu.listeZones.Add(zone3);
            jeu.listeZones.Add(zone4);
            jeu.listeZones.Add(zone5);
            jeu.listeZones.Add(zone6);
            jeu.listeZones.Add(zone7);
            jeu.listeZones.Add(zone8);


            PersonnageAbstrait feu1 = jeu.fab.CreerPersonnage(1, "0", "Feu 1", "10", "vert", zone3, null);
            PersonnageAbstrait feu2 = jeu.fab.CreerPersonnage(2, "0", "Feu 2", "10", "rouge", zone7, (SujetObserveAbstrait)feu1);
            zone3.listePersonnages.Add(feu1);
            zone7.listePersonnages.Add(feu2);

            PersonnageAbstrait voiture1 = jeu.fab.CreerPersonnage(3, "2", "Voiture 1", "", "", zone1, null);
            PersonnageAbstrait voiture2 = jeu.fab.CreerPersonnage(4, "2", "Voiture 2", "", "", zone5, null);
            
            jeu.listePersonnages.Add(voiture1);
            jeu.listePersonnages.Add(voiture2);
            jeu.listePersonnages.Add(feu1);
            jeu.listePersonnages.Add(feu2);


           m_oWorker.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
		{
            jeu = new Simulation("JeuEchecs", 1000);

			jeu.fab = new FabriqueJeuEchecs (false);
			jeu.ModuleIHM = new ModuleIHM_Echecs (false);
			jeu.ModuleIHM.jeu = jeu;

			jeu.ModuleStats = new ModuleStats_Echecs ();
			jeu.ModuleStats.jeu = jeu;


			ZoneAbstraite[][] zones = new ZoneAbstraite [8][];

			for (int i = 0; i < 8; i++) {
				zones[i] = new ZoneAbstraite[8];
				for (int j = 0; j < 8; j++) {
					zones [i] [j] = jeu.fab.CreerZone (0, new List<PersonnageAbstrait> (), null, i, j);
				}
			}

			for (int i = 0; i < 8; i++) {
				for (int j = 0; j < 8; j++) {
					if( i - 1 >= 0)
						jeu.fab.CreerAcces(zones[i][j], zones[i - 1][j], true);
					if( i + 1 <= 7)
						jeu.fab.CreerAcces(zones[i][j], zones[i + 1][j], true);
					if( j - 1 >= 0)
						jeu.fab.CreerAcces(zones[i][j], zones[i][j - 1], true);
					if( j + 1 <= 7)
						jeu.fab.CreerAcces(zones[i][j], zones[i][j + 1], true);
				}
			}
			for (int i = 0; i < 8; i++) 
				for (int j = 0; j < 8; j++) 
					jeu.listeZones.Add(zones[i][j]);
			int y;
			String color, piece, type;
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
						jeu.listePersonnages.Add(jeu.fab.CreerPersonnage (0, FabriqueJeuEchecs.typePion, "WP", "1", null, zones [j] [1], null));
					} else {
						jeu.listePersonnages.Add(jeu.fab.CreerPersonnage (0, FabriqueJeuEchecs.typePion, "BP", "1", null, zones [j] [6], null));
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
					jeu.listePersonnages.Add(jeu.fab.CreerPersonnage (0, type, color + piece, "1", null, zones [j] [y], null));
				}
			}

			m_oWorker.RunWorkerAsync();
		}

        private void bChargement_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "xml files (*.xml)|*.xml" ;
            openFileDialog1.FilterIndex = 2 ;
            openFileDialog1.RestoreDirectory = true ;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.InitialDirectory = openFileDialog1.FileName.Remove(openFileDialog1.FileName.LastIndexOf("\\"));
                location_fileDialog = Path.GetDirectoryName(openFileDialog1.FileName);

                try
                {
                    cheminXML.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
        }

        private void bLancer_Click(object sender, EventArgs e)
        {
            if (cheminXML.TextLength > 0)
            {
                
				jeu = new Simulation ("",1000);

                jeu.chargerSimulation(cheminXML.Text);

                m_oWorker.RunWorkerAsync();

            }
        }
    }
}

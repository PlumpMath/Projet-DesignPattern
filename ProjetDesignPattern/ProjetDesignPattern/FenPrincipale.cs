//using ProjetDesignPattern.JeuSimulationTrafic;
using ProjetDesignPattern.JeuDefenceTower;
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

        BackgroundWorker m_oWorker;
        Simulation jeu;

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
        }

        private void FenPrincipale_Load(object sender, System.EventArgs e)
        {
        }


        private void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("C'est la fin du jeu");

        }

        private void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            jeu.Afficher();
        }

        private void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                System.Threading.Thread.Sleep(1000);
                jeu.TourDeJeu();
                m_oWorker.ReportProgress(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jeu = new Simulation("Defence Tower");
            jeu.fab = new FabriqueJeuDT();
            jeu.ModuleIHM = new ModuleIHMDT(jeu);
            jeu.ModuleIHM.jeu = jeu;

            jeu.ModuleStats = new ModuleStat_DT();
            jeu.ModuleStats.jeu = jeu;

            /*
            //zones
            for (int i = 0; i < 10; i++)//x
            {
                for (int j = 0; j < 11; j++)//y
                {
                    ZoneDT z = (ZoneDT)jeu.fab.CreerZone();
                    z.créerZoneDT(i, j);
                    jeu.listeZones.Add(z);
                }
            }
            //acces
            */

            ZoneDT zone1 = (ZoneDT)jeu.fab.CreerZone();
            zone1.créerZoneDT(0, 5);
            ZoneDT zone2 = (ZoneDT)jeu.fab.CreerZone();
            zone2.créerZoneDT(1, 5);
            ZoneDT zone3 = (ZoneDT)jeu.fab.CreerZone();
            zone3.créerZoneDT(2, 5);
            ZoneDT zone4 = (ZoneDT)jeu.fab.CreerZone();
            zone4.créerZoneDT(3, 5);
            ZoneDT zone5 = (ZoneDT)jeu.fab.CreerZone();
            zone5.créerZoneDT(4, 5);
            ZoneDT zone6 = (ZoneDT)jeu.fab.CreerZone();
            zone6.créerZoneDT(5, 5);
            ZoneDT zone7 = (ZoneDT)jeu.fab.CreerZone();
            zone7.créerZoneDT(6, 5);
            ZoneDT zone8 = (ZoneDT)jeu.fab.CreerZone();
            zone8.créerZoneDT(7, 5);
            ZoneDT zone9 = (ZoneDT)jeu.fab.CreerZone();
            zone9.créerZoneDT(8, 5);
            ZoneDT zone10 = (ZoneDT)jeu.fab.CreerZone();
            zone10.créerZoneDT(9, 5);

            //chateau
            ZoneDT zonechateau = (ZoneDT)jeu.fab.CreerZone();
            zonechateau.créerZoneDT(10, 5);
            zonechateau.nomImageZone = "chateau";

            jeu.fab.CreerAcces(zone1, zone2);
            jeu.fab.CreerAcces(zone2, zone3);
            jeu.fab.CreerAcces(zone3, zone4);
            jeu.fab.CreerAcces(zone4, zone5);
            jeu.fab.CreerAcces(zone5, zone6);
            jeu.fab.CreerAcces(zone6, zone7);
            jeu.fab.CreerAcces(zone7, zone8);
            jeu.fab.CreerAcces(zone8, zone9);
            jeu.fab.CreerAcces(zone9, zone10);

            //chateau
            jeu.fab.CreerAcces(zone10, zonechateau);

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
            jeu.listeZones.Add(zonechateau);


            Chateau chateau = (Chateau)jeu.fab.CreerPersonnage(1, null, "chateau", zonechateau);
            chateau.initChateau(10, 10,1);
            Ennemi ennemi = (Ennemi)jeu.fab.CreerPersonnage(2,null,"ennemi",zone1);
            ennemi.initEnnemi(chateau, 10, 1,2);
            zone1.attacherEnnemi(ennemi);
            Ennemi ennemi2 = (Ennemi)jeu.fab.CreerPersonnage(2, null, "ennemi2", zone1);
            ennemi2.initEnnemi(chateau, 10, 1, 2);
            zone1.attacherEnnemi(ennemi2);
            Ennemi ennemi3 = (Ennemi)jeu.fab.CreerPersonnage(2, null, "ennemi3", zone1);
            ennemi3.initEnnemi(chateau, 10, 1, 2);
            zone1.attacherEnnemi(ennemi3);
            Ennemi ennemi4 = (Ennemi)jeu.fab.CreerPersonnage(2, null, "ennemi4", zone1);
            ennemi4.initEnnemi(chateau, 10, 1, 2);
            zone1.attacherEnnemi(ennemi4);

            jeu.listePersonnages.Add(chateau);
            jeu.listePersonnages.Add(ennemi);
            jeu.listePersonnages.Add(ennemi2);
            jeu.listePersonnages.Add(ennemi3);
            jeu.listePersonnages.Add(ennemi4);
            //jeu.Afficher();
            m_oWorker.RunWorkerAsync();
            
            //for (int i = 0; i < 20; i++)
            //{
            //    System.Threading.Thread.Sleep(50);
            //    jeu.TourDeJeu();
            //}

        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //    Simulation jeu = new Simulation("Simulation traffic");
        //    jeu.fab = new FabriqueSimuTrafic();
        //    jeu.ModuleIHM = new ModuleIHM_Trafic();
        //    jeu.ModuleIHM.jeu = jeu;

        //    jeu.ModuleStats = new ModuleStats_Trafic();
        //    jeu.ModuleStats.jeu = jeu;
            
        //    ZoneAbstraite zone1 = jeu.fab.CreerZone();
        //    ZoneAbstraite zone2 = jeu.fab.CreerZone();
        //    ZoneAbstraite zone3 = jeu.fab.CreerZone();
        //    ZoneAbstraite zone4 = jeu.fab.CreerZone();
        //    ZoneAbstraite zone5 = jeu.fab.CreerZone();
        //    ZoneAbstraite zone6 = jeu.fab.CreerZone();
        //    ZoneAbstraite zone7 = jeu.fab.CreerZone();
        //    ZoneAbstraite zone8 = jeu.fab.CreerZone();

        //    jeu.fab.CreerAcces(zone1, zone2);
        //    jeu.fab.CreerAcces(zone2, zone3);
        //    jeu.fab.CreerAcces(zone3, zone4);
        //    jeu.fab.CreerAcces(zone4, zone5);
        //    jeu.fab.CreerAcces(zone5, zone6);
        //    jeu.fab.CreerAcces(zone6, zone7);
        //    jeu.fab.CreerAcces(zone7, zone8);
        //    jeu.fab.CreerAcces(zone8, zone1);

        //    jeu.listeZones.Add(zone1);
        //    jeu.listeZones.Add(zone2);
        //    jeu.listeZones.Add(zone3);
        //    jeu.listeZones.Add(zone4);
        //    jeu.listeZones.Add(zone5);
        //    jeu.listeZones.Add(zone6);
        //    jeu.listeZones.Add(zone7);
        //    jeu.listeZones.Add(zone8);

        //    PersonnageAbstrait feu = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeFeu, null, "Feu", zone3);
        //    PersonnageAbstrait voiture1 = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeVoiture, null, "voiture", zone1);
        //    PersonnageAbstrait voiture2 = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeVoiture, null, "voiture2", zone2);
        //    jeu.listePersonnages.Add(voiture1);
        //    jeu.listePersonnages.Add(voiture2);

        //    jeu.Afficher();

        //    for (int i = 0; i < 20; i++)
        //    {
        //        System.Threading.Thread.Sleep(500);
        //        jeu.TourDeJeu();
        //    }
        //}


    }
}

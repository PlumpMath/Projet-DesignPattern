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

        private void FenPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            jeu = new Simulation("Simulation traffic");
            jeu.fab = new FabriqueSimuTrafic();
            jeu.ModuleIHM = new ModuleIHM_Trafic();
            jeu.ModuleIHM.jeu = jeu;

            jeu.ModuleStats = new ModuleStats_Trafic();
            jeu.ModuleStats.jeu = jeu;

            ZoneAbstraite zone1 = jeu.fab.CreerZone();
            zone1.positionX = 0;
            zone1.positionY = 0;
            ZoneAbstraite zone2 = jeu.fab.CreerZone();
            zone2.positionX = 1;
            zone2.positionY = 0;
            ZoneAbstraite zone3 = jeu.fab.CreerZone();
            zone3.positionX = 2;
            zone3.positionY = 0;
            ZoneAbstraite zone4 = jeu.fab.CreerZone();
            zone4.positionX = 2;
            zone4.positionY = 1;
            ZoneAbstraite zone5 = jeu.fab.CreerZone();
            zone5.positionX = 2;
            zone5.positionY = 2;
            ZoneAbstraite zone6 = jeu.fab.CreerZone();
            zone6.positionX = 1;
            zone6.positionY = 2;
            ZoneAbstraite zone7 = jeu.fab.CreerZone();
            zone7.positionX = 0;
            zone7.positionY = 2;
            ZoneAbstraite zone8 = jeu.fab.CreerZone();
            zone8.positionX = 0;
            zone8.positionY = 1;

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

            PersonnageAbstrait feu1 = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeFeu, null, "Feu", zone3);
            ((FeuSignalisation)feu1).Etat = FeuSignalisation.vert;

            PersonnageAbstrait feu2 = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeFeu, (SujetObserveAbstrait)feu1, "Feu", zone7);
            

            PersonnageAbstrait voiture1 = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeVoiture, null, "voiture", zone1);
            PersonnageAbstrait voiture2 = jeu.fab.CreerPersonnage(FabriqueSimuTrafic.typeVoiture, null, "voiture2", zone5);
            jeu.listePersonnages.Add(voiture1);
            jeu.listePersonnages.Add(voiture2);
            jeu.listePersonnages.Add(feu1);
            jeu.listePersonnages.Add(feu2);

            
            jeu.Afficher();

            for (int i = 0; i < 30; i++)
            {
                System.Threading.Thread.Sleep(250);
                jeu.TourDeJeu();
            }

            //m_oWorker.RunWorkerAsync();

        }
    }
}

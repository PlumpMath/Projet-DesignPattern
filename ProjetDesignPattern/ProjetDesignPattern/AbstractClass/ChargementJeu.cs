﻿using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using ProjetDesignPattern.JeuDefenceTower;

namespace ProjetDesignPattern.AbstractClass
{
    public class ChargementJeu
    {

        private static System.Xml.XmlTextReader txtReader = null;

        public ChargementJeu ()
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Users\\Ludwig\\Desktop" ;
            openFileDialog1.Filter = "xml files (*.xml)|*.xml" ;
            openFileDialog1.FilterIndex = 2 ;
            openFileDialog1.RestoreDirectory = true ;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    XDocument monDoc = XDocument.Load(openFileDialog1.FileName);

                    //Fabrique du jeu
                    var jeu = monDoc.Element("Simulateur").Element("Jeu").Attribute("nom");
                    if (jeu.ToString() == "echec")
                    {
                        FabriqueJeuDT fDT = new FabriqueJeuDT();
                    }
                    if (jeu.ToString() == "echec")
                    {
                        FabriqueJeuDT fDT = new FabriqueJeuDT();
                    }
                    if (jeu.ToString() == "echec")
                    {
                        FabriqueJeuDT fDT = new FabriqueJeuDT();
                    }
                          
                    //Fabrique des zones
                    /*var zones = monDoc.Element("Simulateur").Element("Jeu").Element("Zones").Element("zone").Descendants();

                    foreach (XElement el in zones)
                        ZoneAbstraite d = new ZoneAbstraite();
                    */

                    ////////////////////////EXEMPLES/////////////////////////////////////////

                    /*var nodes = (from n in monDoc.Elements()
                                 where n.Name == "Zones"
                                 select n).First();

                    var q = from b in monDoc.Descendants("Zones")
                            select new
                            {
                                x = (string)b.Element("x"),
                                y = (string)b.Element("y"),
                                acc = (string)b.Element("acces")
                            };
                    */
                    var result = monDoc.Element("Simulateur").Descendants();
                    foreach (XElement el in result)
                    MessageBox.Show(el.Name.ToString());
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
           
        }
        
    }
}

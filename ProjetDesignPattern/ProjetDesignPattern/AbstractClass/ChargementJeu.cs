using System;
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

        public Simulation maSimulation;
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
                    
                    maSimulation =  new Simulation(jeu.ToString());

                          
                    //Fabrique des zones
                    var zones = monDoc.Element("Simulateur").Element("Jeu").Element("Zones").Element("zone").Descendants();

                    foreach (XElement el in zones)
                    {
                        maSimulation.ajoutZone(int.Parse(el.Element("x").ToString()), 
                            int.Parse(el.Element("y").ToString()));

                        var acces = from ac in monDoc.Element("Simulateur").Element("Jeu").Element("Access").Element("acces").Descendants()
                                    join zo in monDoc.Element("Simulateur").Element("Jeu").Element("Zones").Element("zone").Descendants()
                                         on (string)ac.Attribute("idzone") equals (string)zo.Attribute("idzone")
                                    select new 
                                    {
                                        accesX = (int)zo.Element("x"),
                                        accesY = (int)zo.Element("y")
                                    };

                        foreach (var ele in acces)
                        MessageBox.Show(ele.ToString());
                        
                    }
                    
                    //Fabrique des acces
                    //var acces = monDoc.Element("Simulateur").Element("Jeu").Element("Access").Element("acces").Descendants();

                    /*foreach (XElement el in zones)
                    {
                        maSimulation.ajoutZone(int.Parse(el.Element("x").ToString()),
                            int.Parse(el.Element("y").ToString()));
                    }


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
                    //var result = monDoc.Element("Simulateur").Descendants();
                    //foreach (XElement el in result)
                    //MessageBox.Show(el.Name.ToString());
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
           
        }
        
    }
}

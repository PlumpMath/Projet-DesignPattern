using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetDesignPattern
{
    public abstract class Simulation
    {
        public List<ZoneAbstraite> listeZones;
        public List<PersonnageAbstrait> listePersonnages;

        public Simulation(String fab)
        {
             
        }

        public void ajoutZone(int _x, int _y)
        {
        }

        public void ajoutAcces(ZoneAbstraite zone,ZoneAbstraite acces)
        {

        }
    }
}

using System;

namespace ProjetDesignPattern
{
    public abstract class AccesAbstrait
    {
		public ZoneAbstraite départ { get; set; }
        public ZoneAbstraite arrivée { get; set; }
        public bool accès { get; set; }
    }
}

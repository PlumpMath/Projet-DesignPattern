using System;

namespace ProjetDesignPattern
{
    public abstract class AccesAbstrait
    {
		ZoneAbstraite départ { get; set; }
		ZoneAbstraite arrivée { get; set; }
		bool accès { get; set; }
    }
}

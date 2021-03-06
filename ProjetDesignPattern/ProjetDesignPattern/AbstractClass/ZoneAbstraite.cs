﻿using System;
using System.Collections.Generic;

namespace ProjetDesignPattern
{
    public abstract class ZoneAbstraite
    {
        public List<PersonnageAbstrait> listePersonnages;
        public List<ObjetAbstrait> listeObjets;
		public Dictionary<int, AccesAbstrait> zonesAdjacentes { get; set; }
        public int positionX;
        public int positionY;

    }
}

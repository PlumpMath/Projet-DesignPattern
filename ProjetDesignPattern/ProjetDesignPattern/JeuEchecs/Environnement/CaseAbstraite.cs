using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public abstract class CaseAbstraite : ZoneAbstraite
	{
		PieceEchec pièce { get; set; }
		Dictionary<eTypeDéplacement, Case> casesAdjacentes { get; set; }
	}
}

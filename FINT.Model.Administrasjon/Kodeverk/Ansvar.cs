using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Kodeverk;

namespace FINT.Model.Administrasjon.Kodeverk
{
	public class Ansvar : Kontodimensjon {
		public new enum Relasjonsnavn
        {
			OVERORDNET,
			UNDERORDNET,
			ORGANISASJONSELEMENT
        }
        
	
	}
}

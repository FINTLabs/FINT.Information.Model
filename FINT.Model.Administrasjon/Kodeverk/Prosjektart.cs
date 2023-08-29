using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Kodeverk;

namespace FINT.Model.Administrasjon.Kodeverk
{
	public class Prosjektart : Kontodimensjon {
		public new enum Relasjonsnavn
        {
			UNDERORDNET,
			PROSJEKT,
			OVERORDNET
        }
        
	
	}
}

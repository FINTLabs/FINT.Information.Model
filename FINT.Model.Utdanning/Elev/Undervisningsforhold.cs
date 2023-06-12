using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{
	public class Undervisningsforhold : Utdanningsforhold {
		public new enum Relasjonsnavn
        {
			ARBEIDSFORHOLD,
			BASISGRUPPE,
			KONTAKTLARERGRUPPE,
			UNDERVISNINGSGRUPPE,
			EKSAMENSGRUPPE,
			TIME,
			SKOLE,
			SKOLERESSURS
        }
        
	
		public bool? Hovedskole { get; set; }
		
	}
}

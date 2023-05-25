using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{
	public class Undervisningsforhold : Utdanningsforhold {
		public enum Relasjonsnavn
        {
			ARBEIDSFORHOLD,
			KONTAKTLARERGRUPPE,
			BASISGRUPPE,
			UNDERVISNINGSGRUPPE,
			EKSAMENSGRUPPE,
			TIME,
			SKOLE,
			SKOLERESSURS
        }
        
	
		public bool? Hovedskole { get; set; }
		
	}
}

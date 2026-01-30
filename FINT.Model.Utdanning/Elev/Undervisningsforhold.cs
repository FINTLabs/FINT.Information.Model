using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{
	public class Undervisningsforhold : Utdanningsforhold {
		public enum Relasjonsnavn
        {
			ARBEIDSFORHOLD,
			KLASSE,
			TIME,
			SKOLE,
			KONTAKTLARERGRUPPE,
			SKOLERESSURS,
			UNDERVISNINGSGRUPPE,
			EKSAMENSGRUPPE
        }
        
	
		public bool? Hovedskole { get; set; }
		
	}
}

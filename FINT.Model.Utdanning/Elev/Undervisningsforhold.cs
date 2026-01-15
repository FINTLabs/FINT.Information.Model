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

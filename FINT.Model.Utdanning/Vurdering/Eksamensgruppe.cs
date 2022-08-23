using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Eksamensgruppe : Gruppe {
		public enum Relasjonsnavn
        {
			ELEVFORHOLD,
			FAG,
			SKOLE,
			TERMIN,
			SKOLEAR,
			UNDERVISNINGSFORHOLD,
			GRUPPEMEDLEMSKAP
        }
        
	
		public DateTime? Eksamensdato { get; set; }
		
	}
}

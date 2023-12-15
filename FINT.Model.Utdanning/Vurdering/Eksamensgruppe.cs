using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Eksamensgruppe : Gruppe {
		public new enum Relasjonsnavn
        {
			ELEVFORHOLD,
			EKSAMEN,
			FAG,
			SKOLE,
			TERMIN,
			EKSAMENSFORM,
			SKOLEAR,
			UNDERVISNINGSFORHOLD,
			SENSOR,
			GRUPPEMEDLEMSKAP
        }
        
	
		public DateTime? Eksamensdato { get; set; }
		
	}
}

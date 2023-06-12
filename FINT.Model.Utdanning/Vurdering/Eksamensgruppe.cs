using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Eksamensgruppe : Gruppe {
		public new enum Relasjonsnavn
        {
			ELEVFORHOLD,
			FAG,
			SKOLE,
			TERMIN,
			EKSAMENSFORM,
			SKOLEAR,
			UNDERVISNINGSFORHOLD,
			GRUPPEMEDLEMSKAP,
			SENSOR
        }
        
	
		public DateTime? Eksamensdato { get; set; }
		
	}
}

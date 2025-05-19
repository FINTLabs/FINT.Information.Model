using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Eksamensgruppe : Gruppe {
		public enum Relasjonsnavn
        {
			EKSAMEN,
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

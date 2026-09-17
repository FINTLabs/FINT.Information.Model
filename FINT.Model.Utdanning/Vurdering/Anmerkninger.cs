using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Anmerkninger {
		public enum Relasjonsnavn
        {
			SKOLEAR
        }
        
	
		public long Atferd { get; set; }
		public long Orden { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Vurdering
{
	public abstract class Fagvurdering {
		public enum Relasjonsnavn
        {
			FAG,
			UNDERVISNINGSGRUPPE,
			SKOLEAR,
			KARAKTER
        }
        
	
		public string Kommentar { get; set; }
		public Identifikator SystemId { get; set; }
		public datetime Vurderingsdato { get; set; }
		
	}
}

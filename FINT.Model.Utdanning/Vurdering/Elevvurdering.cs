using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Elevvurdering {
		public enum Relasjonsnavn
        {
			SLUTTFAGVURDERING,
			UNDERVEISORDENSVURDERING,
			VITNEMALSMERKNAD,
			UNDERVEISFAGVURDERING,
			HALVARSORDENSVURDERING,
			ELEVFORHOLD,
			HALVARSFAGVURDERING,
			SLUTTORDENSVURDERING,
			EKSAMENSVURDERING
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}

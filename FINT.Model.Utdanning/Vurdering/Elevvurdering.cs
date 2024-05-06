using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Elevvurdering {
		public enum Relasjonsnavn
        {
			ELEVFORHOLD,
			SLUTTFAGVURDERING,
			UNDERVEISORDENSVURDERING,
			VITNEMALSMERKNAD,
			UNDERVEISFAGVURDERING,
			HALVARSORDENSVURDERING,
			HALVARSFAGVURDERING,
			SLUTTORDENSVURDERING
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}

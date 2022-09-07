using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Vurdering;
using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Elevfravar {
		public enum Relasjonsnavn
        {
			ELEVFORHOLD
        }
        
	
		public List<Fravarsregistrering> Fravar { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{
	public class Medlemskap {
		public enum Relasjonsnavn
        {
			GRUPPE,
			MEDLEM,
			FORTLOPENDEVURDERING,
			ENDELIGVURDERING,
			FRAVAR
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}

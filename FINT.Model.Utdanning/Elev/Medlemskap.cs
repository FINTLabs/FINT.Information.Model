using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{
	public class Medlemskap {
		public enum Relasjonsnavn
        {
			GRUPPE,
			FORTLOPENDEVURDERING,
			ENDELIGVURDERING,
			FRAVAR,
			MEDLEM
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}

// Built from tag v3.6.0-rc-1

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{
	public class Medlemskap {
		public enum Relasjonsnavn
        {
			MEDLEM,
			FORTLOPENDEVURDERING,
			GRUPPE,
			ENDELIGVURDERING,
			FRAVAR
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}

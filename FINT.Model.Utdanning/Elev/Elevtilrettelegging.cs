using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{
	public class Elevtilrettelegging {
		public enum Relasjonsnavn
        {
			FAG,
			TILRETTELEGGING,
			ELEV
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}

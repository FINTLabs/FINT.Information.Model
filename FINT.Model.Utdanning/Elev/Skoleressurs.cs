// Built from tag v3.5.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{
	public class Skoleressurs {
		public enum Relasjonsnavn
        {
			PERSONALRESSURS,
			UNDERVISNINGSFORHOLD,
			SKOLE
        }
        
	
		public Identifikator Feidenavn { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

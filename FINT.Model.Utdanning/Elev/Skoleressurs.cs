// Built from tag v3.6.0-rc-2

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{
	public class Skoleressurs {
		public enum Relasjonsnavn
        {
			PERSON,
			PERSONALRESSURS,
			UNDERVISNINGSFORHOLD,
			SKOLE
        }
        
	
		public Identifikator Feidenavn { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

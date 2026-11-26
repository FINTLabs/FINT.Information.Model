using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{
	public class Skoleressurs {
		public enum Relasjonsnavn
        {
			UNDERVISNINGSFORHOLD,
			PERSONALRESSURS,
			SKOLE,
			PERSON,
			SENSOR
        }
        
	
		public Identifikator Feidenavn { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Larling
{
	public class Larling {
		public enum Relasjonsnavn
        {
			PERSON,
			BEDRIFT,
			PROGRAMOMRADE
        }
        
	
		public string Kontraktstype { get; set; }
		public Periode Laretid { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

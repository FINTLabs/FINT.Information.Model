using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Larling
{
	public class Larling {
		public enum Relasjonsnavn
        {
			PROGRAMOMRADE,
			BEDRIFT,
			PERSON,
			AVLAGTPROVE
        }
        
	
		public string Kontraktstype { get; set; }
		public Periode Laretid { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

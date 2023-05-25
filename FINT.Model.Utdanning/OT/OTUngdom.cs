using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.OT
{
	public class OTUngdom {
		public enum Relasjonsnavn
        {
			PERSON,
			STATUS,
			PROGRAMOMRADE,
			ENHET
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}

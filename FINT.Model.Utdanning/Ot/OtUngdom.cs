using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Ot
{
	public class OtUngdom {
		public enum Relasjonsnavn
        {
			STATUS,
			ENHET,
			PERSON,
			PROGRAMOMRADE
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}

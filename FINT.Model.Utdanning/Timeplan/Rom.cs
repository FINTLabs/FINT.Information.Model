// Built from tag v3.6.0-rc-2

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Timeplan
{
	public class Rom {
		public enum Relasjonsnavn
        {
			TIME
        }
        
	
		public string Navn { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

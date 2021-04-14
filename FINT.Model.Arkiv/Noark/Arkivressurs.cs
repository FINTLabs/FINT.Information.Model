using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Arkiv.Noark
{
	public class Arkivressurs {
		public enum Relasjonsnavn
        {
			AUTORISASJON,
			PERSONALRESSURS,
			TILGANG
        }
        
	
		public Identifikator KildesystemId { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Arkiv.Noark
{
	public class Arkivdel {
		public enum Relasjonsnavn
        {
			KLASSIFIKASJONSSYSTEM,
			REGISTRERING,
			MAPPE
        }
        
	
		public Identifikator SystemId { get; set; }
		public string Tittel { get; set; }
		
	}
}

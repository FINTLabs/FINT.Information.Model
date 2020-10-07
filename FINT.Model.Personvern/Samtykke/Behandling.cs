using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Personvern.Samtykke
{
	public class Behandling {
		public enum Relasjonsnavn
        {
			BEHANDLINGSGRUNNLAG,
			PERSONOPPLYSNING,
			TJENESTE
        }
        
	
		public bool Aktiv { get; set; }
		public string Formal { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

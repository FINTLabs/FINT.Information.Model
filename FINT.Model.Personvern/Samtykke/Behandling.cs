using System;
using System.Collections.Generic;



namespace FINT.Model.Personvern.Samtykke
{
	public class Behandling {
		public enum Relasjonsnavn
        {
			BEHANDLINGSGRUNNLAG,
			PERSONOPPLYSNING,
			SAMTYKKE,
			TJENESTE
        }
        
	
		public bool Aktiv { get; set; }
		public string Formal { get; set; }
		public DateTime? Slettet { get; set; }
		public  SystemId { get; set; }
		
	}
}

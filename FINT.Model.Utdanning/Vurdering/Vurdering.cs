using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Vurdering {
		public enum Relasjonsnavn
        {
			ELEVFORHOLD,
			FAG,
			UNDERVISNINGSGRUPPE,
			KARAKTER,
			EKSAMENSGRUPPE
        }
        
	
		public bool Endelig { get; set; }
		public string Kommentar { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

// Built from tag v3.6.0-rc-1

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Vurdering {
		public enum Relasjonsnavn
        {
			ELEVFORHOLD,
			UNDERVISNINGSGRUPPE,
			EKSAMENSGRUPPE,
			KARAKTER
        }
        
	
		public bool Endelig { get; set; }
		public string Kommentar { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

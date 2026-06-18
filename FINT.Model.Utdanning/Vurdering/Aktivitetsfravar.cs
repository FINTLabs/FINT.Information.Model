using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Aktivitetsfravar {
		public enum Relasjonsnavn
        {
			REGISTRERTAV,
			FAG,
			UNDERVISNINGSGRUPPE,
			FRAVARSTYPE,
			ELEVFRAVAR
        }
        
	
		public DateTime Dato { get; set; }
		public string Kommentar { get; set; }
		public int Minutter { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

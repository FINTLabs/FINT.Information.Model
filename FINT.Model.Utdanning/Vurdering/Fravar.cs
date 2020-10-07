using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Fravar {
		public enum Relasjonsnavn
        {
			ELEVFORHOLD,
			UNDERVISNINGSGRUPPE,
			EKSAMENSGRUPPE,
			FRAVARSTYPE
        }
        
	
		public bool Dokumentert { get; set; }
		public bool ForesPaVitnemal { get; set; }
		public Periode GjelderPeriode { get; set; }
		public string Kommentar { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

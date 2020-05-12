// Built from tag v3.5.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Utdanning.Utdanningsprogram
{
	public class Skole : Enhet {
		public enum Relasjonsnavn
        {
			ORGANISASJON,
			FAG,
			SKOLEEIERTYPE,
			VIGOREFERANSE,
			BASISGRUPPE,
			ELEVFORHOLD,
			KONTAKTLARERGRUPPE,
			SKOLERESSURS,
			UNDERVISNINGSFORHOLD,
			UNDERVISNINGSGRUPPE,
			EKSAMENSGRUPPE,
			UTDANNINGSPROGRAM
        }
        
	
		public string Domenenavn { get; set; }
		public string JuridiskNavn { get; set; }
		public string Navn { get; set; }
		public Identifikator Skolenummer { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

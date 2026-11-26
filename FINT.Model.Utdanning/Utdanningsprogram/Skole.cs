using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Utdanning.Utdanningsprogram
{
	public class Skole : Enhet {
		public enum Relasjonsnavn
        {
			SKOLEEIERTYPE,
			ORGANISASJON,
			VIGOREFERANSE,
			ELEVFORHOLD,
			KLASSE,
			KONTAKTLARERGRUPPE,
			SKOLERESSURS,
			UNDERVISNINGSFORHOLD,
			FAG,
			FAGGRUPPE,
			UNDERVISNINGSGRUPPE,
			UTDANNINGSPROGRAM,
			EKSAMENSGRUPPE
        }
        
	
		public string Domenenavn { get; set; }
		public string JuridiskNavn { get; set; }
		public string Navn { get; set; }
		public Identifikator Skolenummer { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

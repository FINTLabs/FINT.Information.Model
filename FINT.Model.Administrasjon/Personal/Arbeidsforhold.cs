using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{
	public class Arbeidsforhold {
		public enum Relasjonsnavn
        {
			FORMAL,
			RAMME,
			OBJEKT,
			LOPENUMMER,
			KONTRAKT,
			DIVERSE,
			ANLEGG,
			AKTIVITET,
			TIMERPERUKE,
			STILLINGSKODE,
			PROSJEKT,
			FUNKSJON,
			ART,
			ARBEIDSFORHOLDSTYPE,
			ANSVAR,
			ARBEIDSLOKASJON,
			ARBEIDSSTED,
			PERSONALLEDER,
			FASTLONN,
			FASTTILLEGG,
			FRAVAR,
			VARIABELLONN,
			PERSONALRESSURS,
			UNDERVISNINGSFORHOLD
        }
        
	
		public long Ansettelsesprosent { get; set; }
		public Periode Arbeidsforholdsperiode { get; set; }
		public long Arslonn { get; set; }
		public Periode Gyldighetsperiode { get; set; }
		public bool Hovedstilling { get; set; }
		public long Lonnsprosent { get; set; }
		public string Stillingsnummer { get; set; }
		public string Stillingstittel { get; set; }
		public Identifikator SystemId { get; set; }
		public long Tilstedeprosent { get; set; }
		
	}
}

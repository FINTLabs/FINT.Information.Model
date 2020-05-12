// Built from tag v3.5.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{
	public class Personalressurs {
		public enum Relasjonsnavn
        {
			PERSONALRESSURSKATEGORI,
			ARBEIDSFORHOLD,
			PERSON,
			STEDFORTREDER,
			FULLMAKT,
			LEDER,
			PERSONALANSVAR,
			SKOLERESSURS
        }
        
	
		public Identifikator Ansattnummer { get; set; }
		public Periode Ansettelsesperiode { get; set; }
		public DateTime? Ansiennitet { get; set; }
		public Identifikator Brukernavn { get; set; }
		public Kontaktinformasjon Kontaktinformasjon { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

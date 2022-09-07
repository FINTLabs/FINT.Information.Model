using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Noark
{
	public class Korrespondansepart {
		public enum Relasjonsnavn
        {
			KORRESPONDANSEPARTTYPE
        }
        
	
		public Adresse Adresse { get; set; }
		public string Fodselsnummer { get; set; }
		public Kontaktinformasjon Kontaktinformasjon { get; set; }
		public string Kontaktperson { get; set; }
		public string KorrespondansepartNavn { get; set; }
		public string Organisasjonsnummer { get; set; }
		public Skjerming Skjerming { get; set; }
		
	}
}

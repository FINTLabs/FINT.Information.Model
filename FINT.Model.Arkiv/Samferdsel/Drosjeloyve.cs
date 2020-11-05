using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Samferdsel
{
	public class Drosjeloyve : Saksmappe {
	
		public Adresse Forretningsadresse { get; set; }
		public Kontaktinformasjon Kontaktinformasjon { get; set; }
		public string Organisasjonsnavn { get; set; }
		public string Organisasjonsnummer { get; set; }
		public string Soknadsreferanse { get; set; }
		
	}
}

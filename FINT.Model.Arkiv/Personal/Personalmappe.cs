using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Personal
{
	public class Personalmappe : Saksmappe {
		public enum Relasjonsnavn
        {
			PERSON,
			LEDER,
			ARBEIDSSTED,
			PERSONALRESSURS,
			SAKSSTATUS,
			JOURNALENHET,
			ADMINISTRATIVENHET,
			SAKSANSVARLIG,
			ARKIVDEL,
			AVSLUTTETAV,
			OPPRETTETAV
        }
        
	
		public Personnavn Navn { get; set; }
		
	}
}

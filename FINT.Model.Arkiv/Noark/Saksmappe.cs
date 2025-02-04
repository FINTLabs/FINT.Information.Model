using System;
using System.Collections.Generic;



using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Noark
{
	public abstract class Saksmappe : Mappe {
		public new enum Relasjonsnavn
        {
			SAKSMAPPETYPE,
			SAKSSTATUS,
			TILGANGSGRUPPE,
			JOURNALENHET,
			ADMINISTRATIVENHET,
			SAKSANSVARLIG
        }
        
	
		public List<Registrering> Arkivnotat { get; set; }
		public List<Journalpost> Journalpost { get; set; }
		public string Saksaar { get; set; }
		public DateTime? Saksdato { get; set; }
		public string Sakssekvensnummer { get; set; }
		public DateTime? UtlaantDato { get; set; }
		
	}
}

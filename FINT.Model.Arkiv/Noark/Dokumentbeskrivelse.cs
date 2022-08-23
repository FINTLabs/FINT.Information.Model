using System;
using System.Collections.Generic;



using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Noark
{
	public class Dokumentbeskrivelse {
		public enum Relasjonsnavn
        {
			DOKUMENTSTATUS,
			DOKUMENTTYPE,
			TILKNYTTETREGISTRERINGSOM,
			TILKNYTTETAV,
			OPPRETTETAV
        }
        
	
		public string Beskrivelse { get; set; }
		public long? Dokumentnummer { get; set; }
		public List<Dokumentobjekt> Dokumentobjekt { get; set; }
		public List<string> Forfatter { get; set; }
		public DateTime? OpprettetDato { get; set; }
		public List<Part> Part { get; set; }
		public List<string> ReferanseArkivdel { get; set; }
		public Skjerming Skjerming { get; set; }
		public DateTime? TilknyttetDato { get; set; }
		public string Tittel { get; set; }
		
	}
}

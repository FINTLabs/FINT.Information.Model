using System;
using System.Collections.Generic;



using FINT.Model.Arkiv.Noark;
using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Arkiv.Noark
{
	public abstract class Mappe {
	
		public DateTime? AvsluttetDato { get; set; }
		public string Beskrivelse { get; set; }
		public Klasse Klasse { get; set; }
		public Identifikator MappeId { get; set; }
		public List<Merknad> Merknad { get; set; }
		public List<string> Noekkelord { get; set; }
		public string OffentligTittel { get; set; }
		public DateTime? OpprettetDato { get; set; }
		public List<Part> Part { get; set; }
		public Skjerming Skjerming { get; set; }
		public Identifikator SystemId { get; set; }
		public string Tittel { get; set; }
		
	}
}

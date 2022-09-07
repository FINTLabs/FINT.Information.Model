using System;
using System.Collections.Generic;



using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Noark
{
	public class Klasse {
		public enum Relasjonsnavn
        {
			KLASSIFIKASJONSSYSTEM
        }
        
	
		public string KlasseId { get; set; }
		public int? Rekkefolge { get; set; }
		public Skjerming Skjerming { get; set; }
		public string Tittel { get; set; }
		
	}
}

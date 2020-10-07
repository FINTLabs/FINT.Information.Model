using System;
using System.Collections.Generic;



namespace FINT.Model.Arkiv.Noark
{
	public class Dokumentobjekt {
		public enum Relasjonsnavn
        {
			VARIANTFORMAT,
			OPPRETTETAV,
			REFERANSEDOKUMENTFIL
        }
        
	
		public string Filstorrelse { get; set; }
		public string Format { get; set; }
		public string FormatDetaljer { get; set; }
		public string Sjekksum { get; set; }
		public string SjekksumAlgoritme { get; set; }
		public long? Versjonsnummer { get; set; }
		
	}
}
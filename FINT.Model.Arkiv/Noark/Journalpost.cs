using System;
using System.Collections.Generic;



using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Noark
{
	public class Journalpost : Registrering {
		public enum Relasjonsnavn
        {
			JOURNALPOSTTYPE,
			JOURNALSTATUS,
			JOURNALENHET
        }
        
	
		public long? AntallVedlegg { get; set; }
		public DateTime? DokumentetsDato { get; set; }
		public DateTime? ForfallsDato { get; set; }
		public string JournalAr { get; set; }
		public DateTime? JournalDato { get; set; }
		public long? JournalPostnummer { get; set; }
		public long? JournalSekvensnummer { get; set; }
		public DateTime? MottattDato { get; set; }
		public DateTime? OffentlighetsvurdertDato { get; set; }
		public DateTime? SendtDato { get; set; }
		
	}
}

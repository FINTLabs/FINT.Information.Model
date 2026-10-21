using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{
	public class Elevforhold : Utdanningsforhold {
		public enum Relasjonsnavn
        {
			ANMERKNINGER,
			KATEGORI,
			SKOLE,
			AVBRUDDSARSAK,
			FRAVARSREGISTRERINGER,
			ELEV,
			FAGGRUPPEMEDLEMSKAP,
			SKOLEAR,
			TILRETTELEGGING,
			KLASSEMEDLEMSKAP,
			KONTAKTLARERGRUPPEMEDLEMSKAP,
			PERSONGRUPPEMEDLEMSKAP,
			UNDERVISNINGSGRUPPEMEDLEMSKAP,
			PROGRAMOMRADEMEDLEMSKAP,
			EKSAMENSGRUPPEMEDLEMSKAP,
			ELEVVURDERING,
			ELEVFRAVAR
        }
        
	
		public DateTime? Avbruddsdato { get; set; }
		public Periode Gyldighetsperiode { get; set; }
		public bool? Hovedskole { get; set; }
		public bool? TosprakligFagopplaring { get; set; }
		
	}
}

using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Vurdering;
using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{
	public class Elevforhold : Utdanningsforhold {
		public enum Relasjonsnavn
        {
			ELEV,
			SIDEMAL,
			KATEGORI,
			KROPPSOVING,
			SKOLE,
			AVBRUDDSARSAK,
			BASISGRUPPE,
			BASISGRUPPEMEDLEMSKAP,
			UNDERVISNINGSGRUPPEMEDLEMSKAP,
			VURDERING,
			SLUTTORDENSVURDERING,
			KONTAKTLARERGRUPPE,
			UNDERVEISFAGVURDERING,
			HALVARSFAGVURDERING,
			SLUTTFAGVURDERING,
			PERSONGRUPPEMEDLEMSKAP,
			EKSAMENSGRUPPEMEDLEMSKAP,
			KONTAKTLARERGRUPPEMEDLEMSKAP,
			ELEVFRAVAR,
			TILRETTELEGGING,
			HALVARSORDENSVURDERING,
			PROGRAMOMRADE,
			FRAVAR,
			PROGRAMOMRADEMEDLEMSKAP,
			UNDERVEISORDENSVURDERING,
			EKSAMENSGRUPPE,
			UNDERVISNINGSGRUPPE
        }
        
	
		public List<Anmerkninger> Anmerkninger { get; set; }
		public DateTime? Avbruddsdato { get; set; }
		public Periode Gyldighetsperiode { get; set; }
		public bool? Hovedskole { get; set; }
		
	}
}

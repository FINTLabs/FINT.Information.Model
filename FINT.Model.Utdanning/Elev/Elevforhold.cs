using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Vurdering;
using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{
	public class Elevforhold : Utdanningsforhold {
		public new enum Relasjonsnavn
        {
			ELEV,
			SIDEMAL,
			KATEGORI,
			KROPPSOVING,
			SKOLE,
			AVBRUDDSARSAK,
			FRAVARSREGISTRERINGER,
			FAGGRUPPEMEDLEMSKAP,
			SKOLEAR,
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
			ELEVVURDERING,
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
		public bool? TosprakligFagopplaring { get; set; }
		
	}
}

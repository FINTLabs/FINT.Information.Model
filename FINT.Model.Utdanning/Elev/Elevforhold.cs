// Built from tag v3.6.0-rc-1

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{
	public class Elevforhold : Utdanningsforhold {
		public enum Relasjonsnavn
        {
			ELEV,
			KATEGORI,
			SKOLE,
			BASISGRUPPE,
			BASISGRUPPEMEDLEMSKAP,
			UNDERVISNINGSGRUPPEMEDLEMSKAP,
			VURDERING,
			KONTAKTLARERGRUPPE,
			EKSAMENSGRUPPEMEDLEMSKAP,
			KONTAKTLARERGRUPPEMEDLEMSKAP,
			PROGRAMOMRADE,
			FRAVAR,
			PROGRAMOMRADEMEDLEMSKAP,
			EKSAMENSGRUPPE,
			UNDERVISNINGSGRUPPE,
			MEDLEMSKAP
        }
        
	
		public Periode Gyldighetsperiode { get; set; }
		public bool? Hovedskole { get; set; }
		
	}
}

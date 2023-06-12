using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{
	public class Persongruppe : Gruppe {
		public new enum Relasjonsnavn
        {
			ELEV,
			PERSONGRUPPEMEDLEMSKAP,
			TERMIN,
			UNDERVISNINGSFORHOLD,
			SKOLE,
			SKOLERESSURS,
			SKOLEAR
        }
        
	
	}
}

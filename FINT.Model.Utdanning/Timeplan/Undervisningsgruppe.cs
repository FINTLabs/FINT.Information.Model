using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Timeplan
{
	public class Undervisningsgruppe : Gruppe {
		public new enum Relasjonsnavn
        {
			ELEVFORHOLD,
			FAG,
			TERMIN,
			SKOLE,
			SKOLEAR,
			UNDERVISNINGSFORHOLD,
			TIME,
			GRUPPEMEDLEMSKAP
        }
        
	
	}
}

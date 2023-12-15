using System;
using System.Collections.Generic;



using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Eksamensgruppemedlemskap : Gruppemedlemskap {
		public enum Relasjonsnavn
        {
			DELEGERTTIL,
			ELEVFORHOLD,
			FORETRUKKETSKOLE,
			FORETRUKKETSENSOR,
			EKSAMENSGRUPPE,
			NUS
        }
        
	
		public bool? Delegert { get; set; }
		public string Kandidatnummer { get; set; }
		
	}
}

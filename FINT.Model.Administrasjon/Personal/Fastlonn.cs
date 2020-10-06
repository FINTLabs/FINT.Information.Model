// Built from tag v3.6.0-rc-1

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{
	public class Fastlonn : Lonn {
		public enum Relasjonsnavn
        {
			LONNSART,
			ARBEIDSFORHOLD,
			ANVISER,
			KONTERER,
			ATTESTANT
        }
        
	
		public long Prosent { get; set; }
		
	}
}

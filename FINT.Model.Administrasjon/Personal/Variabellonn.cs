// Built from tag v3.6.0-rc-2

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{
	public class Variabellonn : Lonn {
		public enum Relasjonsnavn
        {
			LONNSART,
			ARBEIDSFORHOLD,
			ANVISER,
			KONTERER,
			ATTESTANT
        }
        
	
		public long Antall { get; set; }
		public long? Belop { get; set; }
		
	}
}

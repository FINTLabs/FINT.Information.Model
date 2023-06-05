using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{
	public class Fasttillegg : Lonn {
		public new enum Relasjonsnavn
        {
			LONNSART,
			ARBEIDSFORHOLD
        }
        
	
		public long Belop { get; set; }
		
	}
}

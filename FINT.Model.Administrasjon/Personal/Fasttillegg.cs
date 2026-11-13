using System;
using System.Collections.Generic;



namespace FINT.Model.Administrasjon.Personal
{
	public class Fasttillegg : Lonn {
		public new enum Relasjonsnavn
        {
			ARBEIDSFORHOLD,
			LONNSART
        }
        
	
		public long Belop { get; set; }
		
	}
}

// Built from tag v3.6.0-rc-2

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Fullmakt
{
	public class Fullmakt {
		public enum Relasjonsnavn
        {
			MYNDIGHET,
			STEDFORTREDER,
			FULLMEKTIG,
			ROLLE
        }
        
	
		public Periode Gyldighetsperiode { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}

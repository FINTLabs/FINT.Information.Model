using System;
using System.Collections.Generic;



using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Administrasjon.Kodeverk
{
	public class Lonnsart : Begrep {
		public new enum Relasjonsnavn
        {
			ART
        }
        
	
		public string Kategori { get; set; }
		
	}
}

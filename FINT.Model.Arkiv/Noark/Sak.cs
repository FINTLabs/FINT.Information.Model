using System;
using System.Collections.Generic;



using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Noark
{
	public class Sak : Saksmappe {
		public enum Relasjonsnavn
        {
			SAKSSTATUS,
			JOURNALENHET,
			ADMINISTRATIVENHET,
			SAKSANSVARLIG,
			ARKIVDEL,
			AVSLUTTETAV,
			OPPRETTETAV
        }
        
	
	}
}

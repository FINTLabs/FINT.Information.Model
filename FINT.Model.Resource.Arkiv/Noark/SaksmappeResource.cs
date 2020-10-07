using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Noark
{

    public abstract class SaksmappeResource : MappeResource 
    {

    
        public List<Registrering> Arkivnotat { get; set; }
        public List<JournalpostResource> Journalpost { get; set; }
        public string Saksaar { get; set; }
        public DateTime? Saksdato { get; set; }
        public string Sakssekvensnummer { get; set; }
        public DateTime? UtlaantDato { get; set; }
        
    }
}

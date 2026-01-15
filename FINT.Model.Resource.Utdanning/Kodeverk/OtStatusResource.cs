using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Utdanning.Kodeverk
{

    public class OtStatusResource : BegrepResource 
    {

    
        public string Beskrivelse { get; set; }
        public string Type { get; set; }
        
    }
}

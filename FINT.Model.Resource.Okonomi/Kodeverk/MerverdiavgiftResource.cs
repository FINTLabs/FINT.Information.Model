using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Okonomi.Kodeverk
{

    public class MerverdiavgiftResource : BegrepResource 
    {

    
        public long Sats { get; set; }
        
    }
}

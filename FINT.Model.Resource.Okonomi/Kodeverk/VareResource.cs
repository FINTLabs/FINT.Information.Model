using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Okonomi.Kodeverk
{

    public class VareResource : BegrepResource 
    {

    
        public string Enhet { get; set; }
        public KontostrengResource Kontering { get; set; }
        public long Pris { get; set; }
        
            

        public void AddFakturautsteder(Link link)
        {
            AddLink("fakturautsteder", link);
        }

        public void AddMerverdiavgift(Link link)
        {
            AddLink("merverdiavgift", link);
        }
    }
}

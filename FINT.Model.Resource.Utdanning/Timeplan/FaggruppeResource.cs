using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Timeplan
{

    public class FaggruppeResource : GruppeResource 
    {

    
            

        public void AddFag(Link link)
        {
            AddLink("fag", link);
        }

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }

        public void AddSkolear(Link link)
        {
            AddLink("skolear", link);
        }

        public void AddFaggruppemedlemskap(Link link)
        {
            AddLink("faggruppemedlemskap", link);
        }
    }
}

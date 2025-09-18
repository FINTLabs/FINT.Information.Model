using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Vurdering;

namespace FINT.Model.Utdanning.Vurdering
{

    public class UnderveisfagvurderingResource : FagvurderingResource 
    {

    
            

        public void AddElevvurdering(Link link)
        {
            AddLink("elevvurdering", link);
        }
    }
}

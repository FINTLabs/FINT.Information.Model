using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Vurdering;

namespace FINT.Model.Utdanning.Vurdering
{

    public class HalvarsfagvurderingResource : FagvurderingResource 
    {

    
            

        public void AddElevforhold(Link link)
        {
            AddLink("elevforhold", link);
        }

        public void AddVurdering(Link link)
        {
            AddLink("vurdering", link);
        }
    }
}

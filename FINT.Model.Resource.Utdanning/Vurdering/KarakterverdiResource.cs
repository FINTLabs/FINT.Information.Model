using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Utdanning.Vurdering
{

    public class KarakterverdiResource : BegrepResource 
    {

    
            

        public void AddSkala(Link link)
        {
            AddLink("skala", link);
        }
    }
}

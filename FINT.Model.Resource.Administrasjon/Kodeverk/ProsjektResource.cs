using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Kodeverk;

namespace FINT.Model.Administrasjon.Kodeverk
{

    public class ProsjektResource : KontodimensjonResource 
    {

    
            

        public void AddProsjektart(Link link)
        {
            AddLink("prosjektart", link);
        }
    }
}

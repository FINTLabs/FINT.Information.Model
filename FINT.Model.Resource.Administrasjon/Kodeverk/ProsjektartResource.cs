using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Kodeverk;

namespace FINT.Model.Administrasjon.Kodeverk
{

    public class ProsjektartResource : KontodimensjonResource 
    {

    
            

        public void AddUnderordnet(Link link)
        {
            AddLink("underordnet", link);
        }

        public void AddProsjekt(Link link)
        {
            AddLink("prosjekt", link);
        }

        public void AddOverordnet(Link link)
        {
            AddLink("overordnet", link);
        }
    }
}

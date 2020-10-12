using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Kodeverk;

namespace FINT.Model.Administrasjon.Kodeverk
{

    public class AnsvarResource : KontodimensjonResource 
    {

    
            

        public void AddOverordnet(Link link)
        {
            AddLink("overordnet", link);
        }

        public void AddUnderordnet(Link link)
        {
            AddLink("underordnet", link);
        }

        public void AddOrganisasjonselement(Link link)
        {
            AddLink("organisasjonselement", link);
        }
    }
}

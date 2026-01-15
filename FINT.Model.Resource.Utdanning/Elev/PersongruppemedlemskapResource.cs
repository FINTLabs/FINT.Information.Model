using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{

    public class PersongruppemedlemskapResource : GruppemedlemskapResource 
    {

    
            

        public void AddElevforhold(Link link)
        {
            AddLink("elevforhold", link);
        }

        public void AddPersongruppe(Link link)
        {
            AddLink("persongruppe", link);
        }
    }
}

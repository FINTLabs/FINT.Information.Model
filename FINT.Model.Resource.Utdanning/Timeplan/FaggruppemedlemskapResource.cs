using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Timeplan
{

    public class FaggruppemedlemskapResource : GruppemedlemskapResource 
    {

    
            

        public void AddFagmerknad(Link link)
        {
            AddLink("fagmerknad", link);
        }

        public void AddFagstatus(Link link)
        {
            AddLink("fagstatus", link);
        }

        public void AddElevforhold(Link link)
        {
            AddLink("elevforhold", link);
        }

        public void AddVarsel(Link link)
        {
            AddLink("varsel", link);
        }

        public void AddFaggruppe(Link link)
        {
            AddLink("faggruppe", link);
        }
    }
}

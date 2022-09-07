using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{

    public class KontaktlarergruppeResource : GruppeResource 
    {

    
            

        public void AddBasisgruppe(Link link)
        {
            AddLink("basisgruppe", link);
        }

        public void AddElevforhold(Link link)
        {
            AddLink("elevforhold", link);
        }

        public void AddTermin(Link link)
        {
            AddLink("termin", link);
        }

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }

        public void AddSkolear(Link link)
        {
            AddLink("skolear", link);
        }

        public void AddUndervisningsforhold(Link link)
        {
            AddLink("undervisningsforhold", link);
        }

        public void AddGruppemedlemskap(Link link)
        {
            AddLink("gruppemedlemskap", link);
        }
    }
}

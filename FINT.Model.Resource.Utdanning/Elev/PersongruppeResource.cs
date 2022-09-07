using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{

    public class PersongruppeResource : GruppeResource 
    {

    
            

        public void AddElev(Link link)
        {
            AddLink("elev", link);
        }

        public void AddPersongruppemedlemskap(Link link)
        {
            AddLink("persongruppemedlemskap", link);
        }

        public void AddTermin(Link link)
        {
            AddLink("termin", link);
        }

        public void AddUndervisningsforhold(Link link)
        {
            AddLink("undervisningsforhold", link);
        }

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }

        public void AddSkoleressurs(Link link)
        {
            AddLink("skoleressurs", link);
        }

        public void AddSkolear(Link link)
        {
            AddLink("skolear", link);
        }
    }
}

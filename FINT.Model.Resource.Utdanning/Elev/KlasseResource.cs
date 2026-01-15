using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{

    public class KlasseResource : GruppeResource 
    {

    
            

        public void AddSkolear(Link link)
        {
            AddLink("skolear", link);
        }

        public void AddTermin(Link link)
        {
            AddLink("termin", link);
        }

        public void AddTrinn(Link link)
        {
            AddLink("trinn", link);
        }

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }

        public void AddUndervisningsforhold(Link link)
        {
            AddLink("undervisningsforhold", link);
        }

        public void AddKlassemedlemskap(Link link)
        {
            AddLink("klassemedlemskap", link);
        }

        public void AddKontaktlarergruppe(Link link)
        {
            AddLink("kontaktlarergruppe", link);
        }
    }
}

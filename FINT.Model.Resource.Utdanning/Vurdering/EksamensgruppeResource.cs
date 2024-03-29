using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Vurdering
{

    public class EksamensgruppeResource : GruppeResource 
    {

    
        public DateTime? Eksamensdato { get; set; }
        
            

        public void AddElevforhold(Link link)
        {
            AddLink("elevforhold", link);
        }

        public void AddEksamen(Link link)
        {
            AddLink("eksamen", link);
        }

        public void AddFag(Link link)
        {
            AddLink("fag", link);
        }

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }

        public void AddTermin(Link link)
        {
            AddLink("termin", link);
        }

        public void AddEksamensform(Link link)
        {
            AddLink("eksamensform", link);
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

        public void AddSensor(Link link)
        {
            AddLink("sensor", link);
        }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Vurdering
{

    public class EksamensgruppemedlemskapResource : GruppemedlemskapResource 
    {

    
        public bool? Delegert { get; set; }
        public string Kandidatnummer { get; set; }
        
            

        public void AddDelegertTil(Link link)
        {
            AddLink("delegertTil", link);
        }

        public void AddElevforhold(Link link)
        {
            AddLink("elevforhold", link);
        }

        public void AddForetrukketSkole(Link link)
        {
            AddLink("foretrukketSkole", link);
        }

        public void AddEksamensgruppe(Link link)
        {
            AddLink("eksamensgruppe", link);
        }

        public void AddNus(Link link)
        {
            AddLink("nus", link);
        }

        public void AddBetalingsstatus(Link link)
        {
            AddLink("betalingsstatus", link);
        }

        public void AddForetrukketSensor(Link link)
        {
            AddLink("foretrukketSensor", link);
        }
    }
}

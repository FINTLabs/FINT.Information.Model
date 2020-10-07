using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Noark
{

    public class SakResource : SaksmappeResource 
    {

    
            

        public void AddSaksstatus(Link link)
        {
            AddLink("saksstatus", link);
        }

        public void AddJournalenhet(Link link)
        {
            AddLink("journalenhet", link);
        }

        public void AddAdministrativEnhet(Link link)
        {
            AddLink("administrativEnhet", link);
        }

        public void AddSaksansvarlig(Link link)
        {
            AddLink("saksansvarlig", link);
        }

        public void AddArkivdel(Link link)
        {
            AddLink("arkivdel", link);
        }

        public void AddAvsluttetAv(Link link)
        {
            AddLink("avsluttetAv", link);
        }

        public void AddOpprettetAv(Link link)
        {
            AddLink("opprettetAv", link);
        }
    }
}

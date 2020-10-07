using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Kulturminnevern
{

    public class DispensasjonAutomatiskFredaKulturminneResource : SaksmappeResource 
    {

    
        public string KulturminneId { get; set; }
        public MatrikkelnummerResource Matrikkelnummer { get; set; }
        public Identifikator Soknadsnummer { get; set; }
        
            

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

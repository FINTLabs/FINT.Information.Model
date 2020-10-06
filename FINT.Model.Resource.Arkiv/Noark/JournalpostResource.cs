using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Arkiv.Noark;

namespace FINT.Model.Arkiv.Noark
{

    public class JournalpostResource : RegistreringResource 
    {

    
        public long? AntallVedlegg { get; set; }
        public DateTime? DokumentetsDato { get; set; }
        public DateTime? ForfallsDato { get; set; }
        public string JournalAr { get; set; }
        public DateTime? JournalDato { get; set; }
        public long? JournalPostnummer { get; set; }
        public long? JournalSekvensnummer { get; set; }
        public DateTime? MottattDato { get; set; }
        public DateTime? OffentlighetsvurdertDato { get; set; }
        public DateTime? SendtDato { get; set; }
        
            

        public void AddJournalposttype(Link link)
        {
            AddLink("journalposttype", link);
        }

        public void AddJournalstatus(Link link)
        {
            AddLink("journalstatus", link);
        }

        public void AddJournalenhet(Link link)
        {
            AddLink("journalenhet", link);
        }

        public void AddAdministrativEnhet(Link link)
        {
            AddLink("administrativEnhet", link);
        }

        public void AddArkivdel(Link link)
        {
            AddLink("arkivdel", link);
        }

        public void AddSaksbehandler(Link link)
        {
            AddLink("saksbehandler", link);
        }

        public void AddArkivertAv(Link link)
        {
            AddLink("arkivertAv", link);
        }

        public void AddOpprettetAv(Link link)
        {
            AddLink("opprettetAv", link);
        }
    }
}

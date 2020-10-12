using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Timeplan
{

    public class FagResource : GruppeResource 
    {

    
            

        public void AddProgramomrade(Link link)
        {
            AddLink("programomrade", link);
        }

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }

        public void AddUndervisningsgruppe(Link link)
        {
            AddLink("undervisningsgruppe", link);
        }

        public void AddEksamensgruppe(Link link)
        {
            AddLink("eksamensgruppe", link);
        }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Utdanningsprogram
{

    public class UtdanningsprogramResource : GruppeResource 
    {

    
            

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }

        public void AddProgramomrade(Link link)
        {
            AddLink("programomrade", link);
        }
    }
}

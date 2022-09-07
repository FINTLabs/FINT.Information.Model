using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Utdanningsprogram
{

    public class ArstrinnResource : GruppeResource 
    {

    
            

        public void AddProgramomrade(Link link)
        {
            AddLink("programomrade", link);
        }

        public void AddBasisgruppe(Link link)
        {
            AddLink("basisgruppe", link);
        }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Utdanningsprogram
{

    public class ArstrinnResource : GruppeResource 
    {

    
            

        public void AddVigoreferanse(Link link)
        {
            AddLink("vigoreferanse", link);
        }

        public void AddGrepreferanse(Link link)
        {
            AddLink("grepreferanse", link);
        }

        public void AddProgramomrade(Link link)
        {
            AddLink("programomrade", link);
        }

        public void AddKlasse(Link link)
        {
            AddLink("klasse", link);
        }
    }
}

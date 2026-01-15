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

        public void AddGrepreferanse(Link link)
        {
            AddLink("grepreferanse", link);
        }

        public void AddVigoreferanse(Link link)
        {
            AddLink("vigoreferanse", link);
        }

        public void AddProgramomrade(Link link)
        {
            AddLink("programomrade", link);
        }
    }
}

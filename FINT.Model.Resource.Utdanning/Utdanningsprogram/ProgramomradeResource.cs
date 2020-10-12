using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Utdanningsprogram
{

    public class ProgramomradeResource : GruppeResource 
    {

    
            

        public void AddElevforhold(Link link)
        {
            AddLink("elevforhold", link);
        }

        public void AddUtdanningsprogram(Link link)
        {
            AddLink("utdanningsprogram", link);
        }

        public void AddFag(Link link)
        {
            AddLink("fag", link);
        }

        public void AddTrinn(Link link)
        {
            AddLink("trinn", link);
        }

        public void AddGruppemedlemskap(Link link)
        {
            AddLink("gruppemedlemskap", link);
        }
    }
}

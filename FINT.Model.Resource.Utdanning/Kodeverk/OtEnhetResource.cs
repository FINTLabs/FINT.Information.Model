using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Utdanning.Kodeverk
{

    public class OtEnhetResource : BegrepResource 
    {

    
            

        public void AddKommune(Link link)
        {
            AddLink("kommune", link);
        }
    }
}

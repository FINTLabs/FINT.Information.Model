using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Felles.Kodeverk
{

    public class FylkeResource : BegrepResource 
    {

    
            

        public void AddKommune(Link link)
        {
            AddLink("kommune", link);
        }
    }
}

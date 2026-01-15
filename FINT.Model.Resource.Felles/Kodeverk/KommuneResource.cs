using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Felles.Kodeverk
{

    public class KommuneResource : BegrepResource 
    {

    
            

        public void AddFylke(Link link)
        {
            AddLink("fylke", link);
        }
    }
}

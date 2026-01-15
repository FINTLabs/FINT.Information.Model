using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Utdanning.Kodeverk
{

    public class KarakterskalaResource : BegrepResource 
    {

    
            

        public void AddVigoreferanse(Link link)
        {
            AddLink("vigoreferanse", link);
        }

        public void AddVerdi(Link link)
        {
            AddLink("verdi", link);
        }
    }
}

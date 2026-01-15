using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Ressurs.Tilgang
{

    public class RettighetResource : BegrepResource 
    {

    
        public string Beskrivelse { get; set; }
        
            

        public void AddIdentitet(Link link)
        {
            AddLink("identitet", link);
        }
    }
}

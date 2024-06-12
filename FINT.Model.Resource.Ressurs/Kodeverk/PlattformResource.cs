using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Ressurs.Kodeverk
{

    public class PlattformResource : Begrep 
    {

    
        public PlattformResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }

        protected void AddLink(string key, Link link)
        {
            if (!Links.ContainsKey(key))
            {
                Links.Add(key, new List<Link>());
            }
            Links[key].Add(link);
        }
     
    }
}

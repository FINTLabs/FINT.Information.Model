using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

namespace FINT.Model.Utdanning.Timeplan
{

    public class FaggruppeResource 
    {

    
        public FaggruppeResource()
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
     
            

        public void AddFag(Link link)
        {
            AddLink("fag", link);
        }

        public void AddFaggruppemedlemskap(Link link)
        {
            AddLink("faggruppemedlemskap", link);
        }
    }
}

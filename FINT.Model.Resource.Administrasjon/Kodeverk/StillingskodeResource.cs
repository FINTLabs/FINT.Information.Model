using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Administrasjon.Kodeverk
{

    public class StillingskodeResource : BegrepResource 
    {

    
            

        public void AddForelder(Link link)
        {
            AddLink("forelder", link);
        }
    }
}

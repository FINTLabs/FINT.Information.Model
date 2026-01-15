using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Administrasjon.Kodeverk
{

    public class LonnsartResource : BegrepResource 
    {

    
        public string Kategori { get; set; }
        
            

        public void AddArt(Link link)
        {
            AddLink("art", link);
        }
    }
}

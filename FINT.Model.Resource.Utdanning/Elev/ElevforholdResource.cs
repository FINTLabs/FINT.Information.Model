using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Vurdering;
using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{

    public class ElevforholdResource : UtdanningsforholdResource 
    {

    
        public List<AnmerkningerResource> Anmerkninger { get; set; }
        public DateTime? Avbruddsdato { get; set; }
        public Periode Gyldighetsperiode { get; set; }
        public bool? Hovedskole { get; set; }
        public bool? TosprakligFagopplaring { get; set; }
        
            

        public void AddElev(Link link)
        {
            AddLink("elev", link);
        }

        public void AddSidemal(Link link)
        {
            AddLink("sidemal", link);
        }

        public void AddKategori(Link link)
        {
            AddLink("kategori", link);
        }

        public void AddKroppsoving(Link link)
        {
            AddLink("kroppsoving", link);
        }

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }

        public void AddAvbruddsarsak(Link link)
        {
            AddLink("avbruddsarsak", link);
        }

        public void AddFravarsregistreringer(Link link)
        {
            AddLink("fravarsregistreringer", link);
        }

        public void AddFaggruppemedlemskap(Link link)
        {
            AddLink("faggruppemedlemskap", link);
        }

        public void AddSkolear(Link link)
        {
            AddLink("skolear", link);
        }

        public void AddBasisgruppe(Link link)
        {
            AddLink("basisgruppe", link);
        }

        public void AddBasisgruppemedlemskap(Link link)
        {
            AddLink("basisgruppemedlemskap", link);
        }

        public void AddUndervisningsgruppemedlemskap(Link link)
        {
            AddLink("undervisningsgruppemedlemskap", link);
        }

        public void AddVurdering(Link link)
        {
            AddLink("vurdering", link);
        }

        public void AddSluttordensvurdering(Link link)
        {
            AddLink("sluttordensvurdering", link);
        }

        public void AddKontaktlarergruppe(Link link)
        {
            AddLink("kontaktlarergruppe", link);
        }

        public void AddUnderveisfagvurdering(Link link)
        {
            AddLink("underveisfagvurdering", link);
        }

        public void AddHalvarsfagvurdering(Link link)
        {
            AddLink("halvarsfagvurdering", link);
        }

        public void AddSluttfagvurdering(Link link)
        {
            AddLink("sluttfagvurdering", link);
        }

        public void AddPersongruppemedlemskap(Link link)
        {
            AddLink("persongruppemedlemskap", link);
        }

        public void AddEksamensgruppemedlemskap(Link link)
        {
            AddLink("eksamensgruppemedlemskap", link);
        }

        public void AddKontaktlarergruppemedlemskap(Link link)
        {
            AddLink("kontaktlarergruppemedlemskap", link);
        }

        public void AddElevfravar(Link link)
        {
            AddLink("elevfravar", link);
        }

        public void AddTilrettelegging(Link link)
        {
            AddLink("tilrettelegging", link);
        }

        public void AddHalvarsordensvurdering(Link link)
        {
            AddLink("halvarsordensvurdering", link);
        }

        public void AddProgramomrade(Link link)
        {
            AddLink("programomrade", link);
        }

        public void AddFravar(Link link)
        {
            AddLink("fravar", link);
        }

        public void AddProgramomrademedlemskap(Link link)
        {
            AddLink("programomrademedlemskap", link);
        }

        public void AddUnderveisordensvurdering(Link link)
        {
            AddLink("underveisordensvurdering", link);
        }

        public void AddEksamensgruppe(Link link)
        {
            AddLink("eksamensgruppe", link);
        }

        public void AddUndervisningsgruppe(Link link)
        {
            AddLink("undervisningsgruppe", link);
        }
    }
}

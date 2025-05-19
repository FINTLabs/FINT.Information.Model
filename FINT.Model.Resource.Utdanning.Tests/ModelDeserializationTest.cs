#pragma warning disable xUnit2002

using System.IO;
using FINT.Model.Utdanning.Elev;
using Newtonsoft.Json;
using Xunit;

namespace FINT.Model.Resource.Utdanning.Tests
{
    public class ModelDeserializationTest
    {
        [Fact(DisplayName = "Read Elev from elev.json")]
        public void Read_Elev_from_elev_json()
        {
            var elev = JsonConvert.DeserializeObject<Elev>(File.ReadAllText(@"./TestData/elev.json"));
            Assert.NotNull(elev);
            Assert.NotNull(elev.Elevnummer);
            Assert.Equal("500001", elev.Elevnummer.Identifikatorverdi);
            Assert.Equal("Yougung", elev.Brukernavn.Identifikatorverdi);
            Assert.NotNull(elev.Brukernavn.Gyldighetsperiode.Start);
        }

        [Fact(DisplayName = "Read ElevResource from elev.json")]
        public void Read_ElevResource_from_elev_json()
        {
            var elev =
                JsonConvert.DeserializeObject<ElevResource>(File.ReadAllText(@"./TestData/elev.json"));

            Assert.NotNull(elev);
            Assert.NotNull(elev.Elevnummer);
            Assert.Equal("500001", elev.Elevnummer.Identifikatorverdi);
            Assert.Equal("Yougung", elev.Brukernavn.Identifikatorverdi);
            Assert.NotNull(elev.Brukernavn.Gyldighetsperiode.Start);
            Assert.NotNull(elev.Links);
            Assert.True(elev.Links.ContainsKey("person"));
            Assert.True(elev.Links.ContainsKey("elevforhold"));
        }

        [Fact(DisplayName = "Read Klasse from klasse.json")]
        public void Read_Klasse_from_klasse_json()
        {
            var klasse =
                JsonConvert.DeserializeObject<Klasse>(File.ReadAllText(@"./TestData/klasse.json"));

            Assert.NotNull(klasse);
            Assert.Equal("ABC123", klasse.Navn);
        }

        [Fact(DisplayName = "Read Klasse from klasseresource.json")]
        public void Read_Klasse_from_klasseresource_json()
        {
            var klasse =
                JsonConvert.DeserializeObject<Klasse>(File.ReadAllText(@"./TestData/klasseresource.json"));

            Assert.NotNull(klasse);
            Assert.Equal("ABC123", klasse.Navn);
        }

        [Fact(DisplayName = "Read KlasseResource from klasse.json")]
        public void Read_KlasseResource_from_klasse_json()
        {
            var klasse =
                JsonConvert.DeserializeObject<KlasseResource>(File.ReadAllText(@"./TestData/klasse.json"));

            Assert.NotNull(klasse);
            Assert.Equal("ABC123", klasse.Navn);
            Assert.NotNull(klasse.Links);
            Assert.Empty(klasse.Links);
        }

        [Fact(DisplayName = "Read KlasseResource from klasseresource.json")]
        public void Read_KlasseResource_from_klasseresource_json()
        {
            var klasse =
                JsonConvert.DeserializeObject<KlasseResource>(File.ReadAllText(@"./TestData/klasseresource.json"));

            Assert.NotNull(klasse);
            Assert.Equal("ABC123", klasse.Navn);
            Assert.NotNull(klasse.Links);
            Assert.True(klasse.Links.ContainsKey("medlemskap"));
        }

    }
}
#pragma warning restore xUnit2002
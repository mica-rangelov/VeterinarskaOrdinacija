using System.Runtime.Serialization.Json;

namespace VeterinarskaOrdinacija.Podaci
{
    // Centralna podešavanja serijalizacije. Bez ovoga DataContractJsonSerializer
    // upisuje DateTime kao "/Date(milisekunde+pomeraj)/" što je ružno.
    // ISO 8601 format ("2020-06-01T00:00:00") je čitljiv i sortabilan.
    public static class Serijalizator
    {
        public static DataContractJsonSerializerSettings Podesavanja()
        {
            return new DataContractJsonSerializerSettings
            {
                DateTimeFormat = new System.Runtime.Serialization.DateTimeFormat("yyyy-MM-ddTHH:mm:ss")
            };
        }
    }
}

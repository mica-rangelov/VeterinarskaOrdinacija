using System.Runtime.Serialization;

namespace VeterinarskaOrdinacija.Modeli
{
    [DataContract]
    public class Korisnik
    {
        [DataMember] public string KorisnickoIme { get; set; }
        [DataMember] public string LozinkaHash { get; set; }
    }
}

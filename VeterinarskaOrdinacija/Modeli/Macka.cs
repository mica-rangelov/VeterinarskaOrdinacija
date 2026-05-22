using System.Runtime.Serialization;

namespace VeterinarskaOrdinacija.Modeli
{
    [DataContract]
    public class Macka : Ljubimac
    {
        [DataMember] public string Rasa { get; set; }
        [DataMember] public bool KucnaMacka { get; set; }
        [DataMember] public string BojaKrzna { get; set; }

        public override string Opis()
        {
            var tip = KucnaMacka ? "kućna" : "spoljna";
            return $"Mačka, rasa {Rasa}, boja krzna {BojaKrzna}, {tip}";
        }
    }
}

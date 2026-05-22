using System.Runtime.Serialization;

namespace VeterinarskaOrdinacija.Modeli
{
    [DataContract]
    public class Pas : Ljubimac
    {
        [DataMember] public string Rasa { get; set; }
        [DataMember] public bool DresiranZaCuvanje { get; set; }
        [DataMember] public double Visina { get; set; }

        public override string Opis()
        {
            var dres = DresiranZaCuvanje ? "dresiran za čuvanje" : "nedresiran";
            return $"Pas, rasa {Rasa}, visina {Visina} cm, {dres}";
        }
    }
}

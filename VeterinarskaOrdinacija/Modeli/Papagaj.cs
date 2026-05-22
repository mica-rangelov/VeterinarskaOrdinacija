using System.Runtime.Serialization;

namespace VeterinarskaOrdinacija.Modeli
{
    [DataContract]
    public class Papagaj : Ljubimac
    {
        [DataMember] public string Boja { get; set; }
        [DataMember] public bool MozeDaPrica { get; set; }
        [DataMember] public int BrojNaucenihReci { get; set; }

        public override string Opis()
        {
            var prica = MozeDaPrica
                ? $"priča ({BrojNaucenihReci} reči)"
                : "ne priča";
            return $"Papagaj, boja {Boja}, {prica}";
        }
    }
}

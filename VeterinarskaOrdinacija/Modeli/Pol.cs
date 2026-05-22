using System.Runtime.Serialization;

namespace VeterinarskaOrdinacija.Modeli
{
    [DataContract]
    public enum Pol
    {
        [EnumMember] Muski = 0,
        [EnumMember] Zenski = 1
    }
}

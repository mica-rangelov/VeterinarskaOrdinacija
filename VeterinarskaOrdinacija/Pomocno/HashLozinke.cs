using System.Security.Cryptography;
using System.Text;

namespace VeterinarskaOrdinacija.Pomocno
{
    public static class HashLozinke
    {
        public static string Hes(string lozinka)
        {
     
            if (lozinka == null) lozinka = string.Empty;
            using (var sha = SHA256.Create())
            {
                var bajtovi = sha.ComputeHash(Encoding.UTF8.GetBytes(lozinka));
                var sb = new StringBuilder(bajtovi.Length * 2);
                foreach (var b in bajtovi) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public static bool Proveri(string lozinka, string hes)
        {
            return Hes(lozinka) == hes;
        }
    }
}

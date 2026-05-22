using System;
using System.IO;

namespace VeterinarskaOrdinacija.Podaci
{
    // Centralno mesto za putanje JSON fajlova.
    // Fajlovi se čuvaju u "data" folderu pored izvršnog fajla.
    public static class Putanje
    {
        public static string Folder
        {
            get
            {
                var f = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
                if (!Directory.Exists(f)) Directory.CreateDirectory(f);
                return f;
            }
        }

        public static string Vlasnici => Path.Combine(Folder, "vlasnici.json");
        public static string Psi => Path.Combine(Folder, "psi.json");
        public static string Macke => Path.Combine(Folder, "macke.json");
        public static string Papagaji => Path.Combine(Folder, "papagaji.json");
        public static string Pregledi => Path.Combine(Folder, "pregledi.json");
        public static string Korisnici => Path.Combine(Folder, "korisnici.json");
    }
}

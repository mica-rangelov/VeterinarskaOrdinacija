using System;
using System.Text.RegularExpressions;

namespace VeterinarskaOrdinacija.Pomocno
{
    public static class Validator
    {
        private static readonly Regex RegexEmail =
            new Regex(@"^[\w\.\-]+@[\w\.\-]+\.\w{2,}$", RegexOptions.Compiled);

        private static readonly Regex RegexTelefon =
            new Regex(@"^[+]?[0-9 \-\/]{6,20}$", RegexOptions.Compiled);

        private static readonly Regex RegexImePrezime =
            new Regex(@"^[A-Za-zČĆŽŠĐčćžšđ][A-Za-zČĆŽŠĐčćžšđ\s\-]{1,49}$", RegexOptions.Compiled);

        public static bool ValidanEmail(string s)
            => !string.IsNullOrWhiteSpace(s) && RegexEmail.IsMatch(s);

        public static bool ValidanTelefon(string s)
            => !string.IsNullOrWhiteSpace(s) && RegexTelefon.IsMatch(s);

        public static bool ValidnoIme(string s)
            => !string.IsNullOrWhiteSpace(s) && RegexImePrezime.IsMatch(s.Trim());

        public static bool ValidnaTezina(double t) => t > 0 && t < 500;

        public static bool ValidanDatumRodjenja(DateTime d)
            => d.Date <= DateTime.Today && d.Year >= 1980;

        public static bool ValidanDatumPregleda(DateTime d)
            => d.Date <= DateTime.Today;
    }
}

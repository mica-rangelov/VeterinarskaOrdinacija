using System;
using System.Windows.Forms;
using VeterinarskaOrdinacija.Forme;
using VeterinarskaOrdinacija.Pomocno;

namespace VeterinarskaOrdinacija
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ako u "data" folderu nema nijednog JSON-a, popuni početne (mock) podatke.
            SeedPodaci.PopuniAkoTreba();

            // Petlja: posle odjave iz glavne forme, ponovo se otvara prijava.
            while (true)
            {
                using (var prijava = new FormaPrijava())
                {
                    if (prijava.ShowDialog() != DialogResult.OK) return;
                }

                Application.Run(new FormaGlavna());

                // Ako je korisnik kliknuo "Odjavi se", FormaGlavna se zatvara
                // i Sesija.UlogovaniKorisnik postaje null — vraća se na prijavu.
                if (Pomocno.Sesija.UlogovaniKorisnik != null) return;
            }
        }
    }
}

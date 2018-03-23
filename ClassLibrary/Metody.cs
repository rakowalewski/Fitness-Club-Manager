using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Basic;
using ClassLibrary.DTO;

namespace ClassLibrary
{
    public class Metody : IMetody
    {
        //Pola
        private DodajUzytkownikaDTO dodajUzytkownikaDTO;
        private LogowanieDTO logowanieDTO;
        private HarmonogramDTO harmonogramDTO;
        private KlienciDTO klienciDTO;
        private TreningDTO treningDTO;
        private WywiadDTO wywiadDTO;
        private ZajeciaDTO zajeciaDTO;

        //Konstruktor
        public Metody()
        {
            dodajUzytkownikaDTO = new DodajUzytkownikaDTO();
            logowanieDTO = new LogowanieDTO();
            klienciDTO = new KlienciDTO();
            harmonogramDTO = new HarmonogramDTO();
            treningDTO = new TreningDTO();
            wywiadDTO = new WywiadDTO();
            zajeciaDTO = new ZajeciaDTO();
        }

        //Właściwości
        public DodajUzytkownikaDTO DodajUzytkownikaDTO { get { return dodajUzytkownikaDTO; } set { dodajUzytkownikaDTO = value; } }

        public LogowanieDTO LogowanieDTO { get { return logowanieDTO; } set { logowanieDTO = value; } }
        public KlienciDTO KlienciDTO { get { return klienciDTO; } set { klienciDTO = value; } }
        public HarmonogramDTO HarmonogramDTO { get { return harmonogramDTO; } set { harmonogramDTO = value; } }
        public TreningDTO TreningDTO { get { return treningDTO; } set { treningDTO = value; } }
        public WywiadDTO WywiadDTO { get { return wywiadDTO; } set { wywiadDTO = value; } }
        public ZajeciaDTO ZajeciaDTO { get { return zajeciaDTO; } set { zajeciaDTO = value; } }


        //Metody
        public void Dodaj_Administratora(Administrator administrator)
        {
            dodajUzytkownikaDTO.Dodaj_Administrator(administrator);
        }

        public void Dodaj_Klienta(Klient klient, string LoginTrenera)
        {
            KlienciDTO.Dodaj_Klienta(klient, LoginTrenera);
        }

        public void Dodaj_Kwote_Treningu(DateTime GodzRozp, double Kwota, int IdKlient, int IdTrener)
        {
            treningDTO.Dodaj_Kwote_Treningu(GodzRozp, Kwota, IdKlient, IdTrener);
        }

        public void Dodaj_Recepcja(Recepcja recepcja)
        {
            dodajUzytkownikaDTO.Dodaj_Recepcja(recepcja);
        }

        public void Dodaj_Trener(Trener trener)
        {
            dodajUzytkownikaDTO.Dodaj_Trener(trener);
        }

        public void Dodaj_Trening(string Data, string GodzRozp, string GodzZak, int IdKlient, int IdTrener)
        {
            treningDTO.Dodaj_Trening(Data, GodzRozp, GodzZak, IdKlient, IdTrener);
        }

        public void Dodaj_Zajecia(Zajecia zajecia)
        {
            zajeciaDTO.Dodaj_Zajecia(zajecia);
        }

        public void Dodaj_Zdjecie(string adresZdjecia, int IdKlient, DateTime dataZrobienia)
        {
            klienciDTO.Dodaj_Zdjecie(adresZdjecia, IdKlient, dataZrobienia);
        }

        public int LogowanieAdministrator(string login, string haslo, string perm)
        {
            return logowanieDTO.LogowanieAdministrator(login, haslo, perm);
        }

        public void Modyfikuj_Administrator(Administrator administrator, string StaryLogin)
        {
            dodajUzytkownikaDTO.Modyfikuj_Administrator(administrator, StaryLogin);
        }

        public void Modyfikuj_Klienta(Klient klient, string StaryPesel)
        {
            klienciDTO.Modyfikuj_Klienta(klient, StaryPesel);
        }

        public void Modyfikuj_Recepcja(Recepcja recepcja, string StaryLogin)
        {
            dodajUzytkownikaDTO.Modyfikuj_Recepcja(recepcja, StaryLogin);
        }

        public void Modyfikuj_Trener(Trener trener, string StaryLogin)
        {
            dodajUzytkownikaDTO.Modyfikuj_Trener(trener, StaryLogin);
        }

        public Administrator Pobierz_Administrator_Login(string Login)
        {
           return logowanieDTO.Pobierz_Administrator_Login(Login);
        }

        public List<Harmonogram> Pobierz_Harmonogram(string Login)
        {
            return harmonogramDTO.Pobierz_Harmonogram(Login);
        }

        public Recepcja Pobierz_Recepcja_Login(string Login)
        {
            return logowanieDTO.Pobierz_Recepcja_Login(Login);
        }

        public Trener Pobierz_Trener_Login(string Login)
        {
            return logowanieDTO.Pobierz_Trener_Login(Login);
        }

        public List<Zajecia> Pobierz_Treningi_Klient(string Pesel)
        {
            return treningDTO.Pobierz_Treningi_Klient(Pesel);
        }

        public List<Zajecia> Pobierz_Trening_Dnia(string Data, string LoginTrenera)
        {
            return treningDTO.Pobierz_Trening_Dnia(Data, LoginTrenera);
        }

        public List<Zajecia> Pobierz_Trening_Historia(string Pesel, string LoginTrenera)
        {
            return treningDTO.Pobierz_Trening_Historia(Pesel, LoginTrenera);
        }

        public List<Zajecia> Pobierz_Trening_Trener(string LoginTrenera)
        {
            return treningDTO.Pobierz_Trening_Trener(LoginTrenera);
        }

        public List<Administrator> Pobierz_Wsz_Administratorow()
        {
            return logowanieDTO.Pobierz_Wsz_Administrator();
        }

        public List<Recepcja> Pobierz_Wsz_Recepcja()
        {
            return logowanieDTO.Pobierz_Wsz_Recepcja();
        }

        public List<Trener> Pobierz_Wsz_Trenerow()
        {
            return logowanieDTO.Pobierz_Wsz_Trener();
        }

        public Wywiad Pobierz_Wywiad(string Pesel)
        {
            return wywiadDTO.Pobierz_Wywiad(Pesel);
        }

        public List<Zajecia> Pobierz_Zajecie()
        {
            return zajeciaDTO.Pobierz_Zajecia();
        }

        public Zdjecie Pobierz_Zdjecie(Zdjecie zdjecie, int IdKlient)
        {
            return klienciDTO.Pobierz_Zdjecie(zdjecie, IdKlient);
        }

        public List<Klient> Pob_Wsz_Klientow(string Pesel, string Nazwisko)
        {
            return klienciDTO.Pob_Wsz_Klienci(Pesel, Nazwisko);
        }

        public double Raport_Miesieczny(string dataPoczatkowa, string dataKoncowa, string LoginTrenera)
        {
            return treningDTO.Raport_Miesieczny(dataPoczatkowa, dataKoncowa, LoginTrenera);
        }

        public double Raport_Roczny(string Rok, string LoginTrener)
        {
            return treningDTO.Raport_Roczny(Rok, LoginTrener);
        }

        public void Update_Harmonogram(Harmonogram Lista, int IdTrener)
        {
            harmonogramDTO.Update_Harmonogram(Lista, IdTrener);
        }

        public List<Klient> Wyszukaj_Klienta(string Pesel)
        {
            return klienciDTO.Wyszukaj_Klient(Pesel);
        }

        public void Zapisz_Wywiad(Wywiad wywiad)
        {
            wywiadDTO.Zapisz_Wywiad(wywiad);
        }


       

    }
}

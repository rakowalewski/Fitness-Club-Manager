using ClassLibrary.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    interface IMetody
    {
        void Dodaj_Administratora(Administrator administrator);
        void Dodaj_Recepcja(Recepcja recepcja);
        void Dodaj_Trener(Trener trener);
        void Modyfikuj_Administrator(Administrator administrator, string StaryLogin);
        void Modyfikuj_Recepcja(Recepcja recepcja, string StaryLogin);
        void Modyfikuj_Trener(Trener trener, string StaryLogin);
        void Dodaj_Klienta(Klient klient, string LoginTrenera);
        void Modyfikuj_Klienta(Klient klient, string StaryPesel);
        List<Klient> Wyszukaj_Klienta(string Pesel);
        List<Klient> Pob_Wsz_Klientow(string Pesel, string Nazwisko);
        void Dodaj_Zdjecie(string adresZdjecia, int IdKlient, DateTime dataZrobienia);
        Zdjecie Pobierz_Zdjecie(Zdjecie zdjecie, int IdKlient);
        Wywiad Pobierz_Wywiad(string Pesel);
        void Zapisz_Wywiad(Wywiad wywiad);
        int LogowanieAdministrator(string login, string haslo, string perm);
        Trener Pobierz_Trener_Login(string Login);
        Administrator Pobierz_Administrator_Login(string Login);
        Recepcja Pobierz_Recepcja_Login(string Login);
        List<Administrator> Pobierz_Wsz_Administratorow();
        List<Trener> Pobierz_Wsz_Trenerow();
        List<Recepcja> Pobierz_Wsz_Recepcja();
        List<Harmonogram> Pobierz_Harmonogram(string Login);
        void Update_Harmonogram(Harmonogram Lista, int IdTrener);
        void Dodaj_Zajecia(Zajecia zajecia);
        List<Zajecia> Pobierz_Zajecie();
        List<Zajecia> Pobierz_Trening_Dnia(string Data, string LoginTrenera);
        List<Zajecia> Pobierz_Trening_Historia(string Pesel, string LoginTrenera);
        List<Zajecia> Pobierz_Trening_Trener(string LoginTrenera);
        void Dodaj_Trening(string Data, string GodzRozp, string GodzZak, int IdKlient, int IdTrener);
        void Dodaj_Kwote_Treningu(DateTime GodzRozp, double Kwota, int IdKlient, int IdTrener);
        double Raport_Miesieczny(string dataPoczatkowa, string dataKoncowa, string LoginTrenera);
        double Raport_Roczny(string Rok, string LoginTrener);
        List<Zajecia> Pobierz_Treningi_Klient(string Pesel);

    }
}

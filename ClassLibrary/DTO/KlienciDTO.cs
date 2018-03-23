using ClassLibrary.Basic;
using ClassLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DTO
{
    public class KlienciDTO
    {
        private KlienciDAO klienciDAO;

        public KlienciDTO()
        {
            klienciDAO = new KlienciDAO();
        }

        public KlienciDAO KlienciDAO
        {
            get { return KlienciDAO; }
            set { KlienciDAO = value; }
        }

        public void Dodaj_Klienta(Klient klient, string LoginTrenera)
        {
            klienciDAO.Dodaj_Klienta(klient, LoginTrenera);
        }

        public void Modyfikuj_Klienta(Klient klient, string StaryPesel)
        {
            klienciDAO.Modyfikuj_Klienta(klient, StaryPesel);
        }
        public List<Klient> Wyszukaj_Klient(string Pesel)
        {
            return klienciDAO.Wyszukaj_Klient(Pesel);
        }

        public List<Klient> Pob_Wsz_Klienci(string Pesel, string nazwisko)
        {
            return klienciDAO.Pob_Wsz_Klienci(Pesel, nazwisko);
        }

        public void Dodaj_Zdjecie(string adresZdjecia, int IdKlient, DateTime dataZrobienia)
        {
            //klienciDAO.Dodaj_Zdjecie(//wpisanie tablicy//, Pesel, LoginTrenera);
        }

        public Zdjecie Pobierz_Zdjecie(Zdjecie zdjecie, int IdKlient)
        {
            return klienciDAO.Pobierz_Zdjecie(zdjecie, IdKlient);
        }
    }
}

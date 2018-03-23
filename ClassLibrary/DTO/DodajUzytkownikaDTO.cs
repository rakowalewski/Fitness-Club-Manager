using ClassLibrary.Basic;
using ClassLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DTO
{
    public class DodajUzytkownikaDTO
    {
        private DodajUzytkownikaDAO dodajUzytkownikaDAO;

        public DodajUzytkownikaDTO()
        {
            dodajUzytkownikaDAO = new DodajUzytkownikaDAO();
        }

        public DodajUzytkownikaDAO DodajUzytkownikaDAO
        {
            get { return DodajUzytkownikaDAO; }
            set { DodajUzytkownikaDAO = value; }
        }

        public void Dodaj_Administrator(Administrator administrator)
        {
            dodajUzytkownikaDAO.Dodaj_Administrator(administrator);
        }

        public void Dodaj_Trener(Trener trener)
        {
            dodajUzytkownikaDAO.Dodaj_Trener(trener);
        }

        public void Dodaj_Recepcja(Recepcja recepcja)
        {
            dodajUzytkownikaDAO.Dodaj_Recepcja(recepcja);
        }

        public void Modyfikuj_Administrator(Administrator administrator, string StaryLogin)
        {
            dodajUzytkownikaDAO.Modyfikuj_Administrator(administrator, StaryLogin);
        }
        public void Modyfikuj_Trener(Trener trener, string StaryLogin)
        {
            dodajUzytkownikaDAO.Modyfikuj_Trener(trener, StaryLogin);
        }

        public void Modyfikuj_Recepcja(Recepcja recepcja, string StaryLogin)
        {
            dodajUzytkownikaDAO.Modyfikuj_Recepcja(recepcja, StaryLogin);
        }
    }

}

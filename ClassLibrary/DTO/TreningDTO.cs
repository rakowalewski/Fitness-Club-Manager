using ClassLibrary.Basic;
using ClassLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DTO
{
    public class TreningDTO
    {
        private TreningDAO treningDAO;
        public TreningDTO()
        {
            treningDAO = new TreningDAO();
        }
        private TreningDAO TreningDAO
        {
            get { return treningDAO; }
            set { treningDAO = value; }
        }

        public void Dodaj_Trening(string Data, string GodzRozp, string GodzZak, int IdKlient, int IdTrener)
        {
            treningDAO.Dodaj_Trening(Data, GodzRozp, GodzZak, IdKlient, IdTrener);
        }
        public List<Zajecia> Pobierz_Trening_Dnia(string Data, string LoginTrenera)
        {
            return treningDAO.Pobierz_Trening_Dnia(Data, LoginTrenera);
        }
        public List<Zajecia> Pobierz_Trening_Historia(string Pesel, string LoginTrenera)
        {
            return treningDAO.Pobierz_Trening_Historia(Pesel, LoginTrenera);
        }

        public List<Zajecia> Pobierz_Trening_Trener(string LoginTrenera)
        {
            return treningDAO.Pobierz_Trening_Trener(LoginTrenera);
        }

        public void Dodaj_Kwote_Treningu(DateTime GodzRozp, double Kwota, int IdKlient, int IdTrener)
        {
            treningDAO.Dodaj_Kwote_Treningu(GodzRozp, Kwota, IdKlient, IdTrener);
        }
        public double Raport_Miesieczny(string dataPoczatkowa, string dataKoncowa, string LoginTrenera)
        {
            return treningDAO.Raport_Miesieczny(dataPoczatkowa, dataKoncowa, LoginTrenera);
        }
        public double Raport_Roczny(string Rok, string LoginTrenera)
        {
            return treningDAO.Raport_Roczny(Rok, LoginTrenera);
        }
        public List<Zajecia> Pobierz_Treningi_Klient(string Pesel)
        {
            return treningDAO.Pobierz_Treningi_Klient(Pesel);
        }
    }
}

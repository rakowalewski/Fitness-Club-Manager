using ClassLibrary.Basic;
using ClassLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DTO
{
    public class ZajeciaDTO
    {
        private ZajeciaDAO zajeciaDAO;

        public ZajeciaDTO()
        {
            zajeciaDAO = new ZajeciaDAO();
        }
        public ZajeciaDAO ZajeciaDAO
        {
            get { return ZajeciaDAO; }
            set { ZajeciaDAO = value; }
        }

        public void Dodaj_Zajecia(Zajecia zajecia)
        {
            zajeciaDAO.Dodaj_Zajecia(zajecia);
        }

        public List<Zajecia> Pobierz_Zajecia()
        {
            return zajeciaDAO.Pobierz_Zajecia();
        }
    }
}

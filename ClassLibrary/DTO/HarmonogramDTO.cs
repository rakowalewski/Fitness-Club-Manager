using ClassLibrary.Basic;
using ClassLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DTO
{
    public class HarmonogramDTO
    {
        private HarmonogramDAO harmonogramDAO;
        public HarmonogramDTO()
        {
            harmonogramDAO = new HarmonogramDAO();
        }
        public HarmonogramDAO HarmonogramDAO
        {
            get { return HarmonogramDAO; }
            set { HarmonogramDAO = value; }
        }

        public List<Harmonogram> Pobierz_Harmonogram(string Login)
        {
            return harmonogramDAO.Pobierz_Harmonogram(Login);
        }

        public void Update_Harmonogram(Harmonogram Lista, int IdTrener)
        {
            harmonogramDAO.Update_Harmonogram(Lista, IdTrener);
        }
    }
}

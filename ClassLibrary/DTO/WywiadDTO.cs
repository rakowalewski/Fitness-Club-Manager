using ClassLibrary.Basic;
using ClassLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DTO
{
    public class WywiadDTO
    {
        private WywiadDAO wywiadDAO;

        public WywiadDTO()
        {
            wywiadDAO = new WywiadDAO();
        }
        public WywiadDAO WywiadDAO
        {
            get { return WywiadDAO; }
            set { WywiadDAO = value; }
        }
        public Wywiad Pobierz_Wywiad(string Pesel)
        {
            return wywiadDAO.Pobierz_Wywiad(Pesel);
        }
        public void Zapisz_Wywiad(Wywiad wywiad)
        {
            wywiadDAO.Zapisz_Wywiad(wywiad);
        }
    }
}

using ClassLibrary.Basic;
using ClassLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DTO
{
    public class LogowanieDTO
    {
        private LogowanieDAO logowanieDAO;

        public LogowanieDTO()
        {
            logowanieDAO = new LogowanieDAO();
        }

        public LogowanieDAO LogowanieDAO
        {
            get { return logowanieDAO; }
            set { logowanieDAO = value; }
        }
        public int LogowanieAdministrator(string login, string haslo, string perm)
        {
            return logowanieDAO.LogowanieAdministrator(login, haslo, perm);
        }
        public Trener Pobierz_Trener_Login(string Login)
        {
            return logowanieDAO.Pobierz_Trener_Login(Login);
        }
        public Administrator Pobierz_Administrator_Login(string Login)
        {
            return logowanieDAO.Pobierz_Administrator_Login(Login);
        }
        public Recepcja Pobierz_Recepcja_Login(string Login)
        {
            return logowanieDAO.Pobierz_Recepcja_Login(Login);
        }
        public List<Administrator> Pobierz_Wsz_Administrator()
        {
            return logowanieDAO.Pobierz_Wsz_Administrator();
        }

        public List<Trener> Pobierz_Wsz_Trener()
        {
            return logowanieDAO.Pobierz_Wsz_Trener();
        }

        public List<Recepcja> Pobierz_Wsz_Recepcja()
        {
            return logowanieDAO.Pobierz_Wsz_Recepcja();
        }
    }
}

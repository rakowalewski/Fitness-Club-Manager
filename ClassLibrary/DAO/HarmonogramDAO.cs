using ClassLibrary.Basic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class HarmonogramDAO : BazaDAO
    {
        public List<Harmonogram> Pobierz_Harmonogram(string Login)
        {
            List<Harmonogram> harmonogramList = new List<Harmonogram>();
            BazaDAO baza = new BazaDAO();
            string query = "Select GodzinaRozpoczecia, GodzinaZakonczenia from Harmonogram as h join Trener as t on h.IdTrener = t.IdTrener where t.Login = @login";
            SqlCommand cmd = new SqlCommand(query, con);
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Harmonogram harmonogram = new Harmonogram();
                harmonogram.GodzinaRozpoczecia = sqlReader["GodzinaRozpoczecia"].ToString();
                harmonogram.GodzinaZakonczenia = sqlReader["GodzinaZakonczenia"].ToString();
                harmonogramList.Add(harmonogram);

            }
            con.Close();
            return harmonogramList;
        }
        public void Update_Harmonogram(Harmonogram Lista, int IdTrener)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Update Harmonogram set IdDzien='" + Lista.IdDzien + "', IdTrener='" + Lista.IdTrener + "', GodzinaRozpoczecia='" + Lista.GodzinaRozpoczecia + "', GodzinaZakonczenia='" + Lista.GodzinaZakonczenia + "' where IdTrener='"+ IdTrener + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();
        }
    }
}

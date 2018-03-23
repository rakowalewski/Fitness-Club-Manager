using ClassLibrary.Basic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class ZajeciaDAO : BazaDAO
    {
        public void Dodaj_Zajecia(Zajecia zajecia)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Insert into Zajecia(IdTrening,NazwaZajec,TypZajec)values(@idtrening,@nazwaZajec,@typZajec)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@idtrening", zajecia.IdTrening));
            cmd.Parameters.Add(new SqlParameter("@nazwaZajec", zajecia.NazwaZajec));
            cmd.Parameters.Add(new SqlParameter("@typZajec", zajecia.TypZajec));
            con.Close();

        }
        public List<Zajecia> Pobierz_Zajecia()
        {
            List<Zajecia> zajeciaList = new List<Zajecia>();
            BazaDAO baza = new BazaDAO();
            string query = "Select NazwaZajec,TypZajec from Zajecia";
            SqlCommand cmd = new SqlCommand(query, con);
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Zajecia zajecia = new Zajecia();
                zajecia.NazwaZajec = sqlReader["NazwaZajec"].ToString();
                zajecia.TypZajec = sqlReader["TypZajec"].ToString();
                zajeciaList.Add(zajecia);

            }
            con.Close();
            return zajeciaList;
        }
    }
}

using ClassLibrary.Basic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class TreningDAO : BazaDAO
    {
       

        public void Dodaj_Trening(string Data, string GodzRozp, string GodzZak, int IdKlient, int IdTrener)
        {
            Trening trening = new Trening();
            BazaDAO baza = new BazaDAO();
            string query = "Insert into Trening(IdTrener,IdKlient,DataGodzRozp,DataGodzZak,CzyZakonczony, Kwota) values(@idtrener,@idklient,@datagodzrozp,@datagodzzak,@czyzakonczony,@kwota)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@idtrener", trening.IdTrener));
            cmd.Parameters.Add(new SqlParameter("@idklient", trening.IdKlient));
            cmd.Parameters.Add(new SqlParameter("@datagodzrozp", trening.DataGodzRozp));
            cmd.Parameters.Add(new SqlParameter("@datagodzzak", trening.DataGodzZak));
            cmd.Parameters.Add(new SqlParameter("@czyzakonczony", trening.CzyZakonczono));
            cmd.Parameters.Add(new SqlParameter("@kwota", trening.Kwota));
            con.Close();
        }

        public List<Zajecia> Pobierz_Trening_Dnia(string Data, string LoginTrenera)
        {
            List<Zajecia> treningList = new List<Zajecia>();
            BazaDAO baza = new BazaDAO();
            string query = "select z.NazwaZajec from Trening as t join Zajecia as z on t.IdTrening = z.IdTrening join Trener as tr on t.IdTrener = tr.IdTrener where t.DataGodzRozp = @termin and tr.Login = @login";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@termin", Data));
            cmd.Parameters.Add(new SqlParameter("@login", LoginTrenera));
           
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Zajecia zajecia = new Zajecia();
                zajecia.NazwaZajec = sqlReader["NazwaZajec"].ToString();
                treningList.Add(zajecia);
            }
            con.Close();
            return treningList;
        }

        public List<Zajecia> Pobierz_Trening_Historia(string Pesel, string LoginTrenera)
        {
            List<Zajecia> treningList = new List<Zajecia>();
            BazaDAO baza = new BazaDAO();
            string query = "select z.NazwaZajec from Trening as t join Zajecia as z on t.IdTrening = z.IdTrening join Trener as tr on t.IdTrener = tr.IdTrener join Klient as k on t.IdKlient = k.IdKlient where tr.Login = @login and k.Pesel = @pesel";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@login", LoginTrenera));
            cmd.Parameters.Add(new SqlParameter("@pesel", Pesel));
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Zajecia zajecia = new Zajecia();
                zajecia.NazwaZajec = sqlReader["NazwaZajec"].ToString();
                treningList.Add(zajecia);
            }
            con.Close();
            return treningList;
        }

        public List<Zajecia> Pobierz_Trening_Trener(string LoginTrenera)
        {
            List<Zajecia> treningList = new List<Zajecia>();
            BazaDAO baza = new BazaDAO();
            string query = "select z.NazwaZajec from Trening as t join Zajecia as z on t.IdTrening = z.IdTrening join Trener as tr on t.IdTrener = tr.IdTrener where tr.Login = @login";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@login", LoginTrenera));

            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Zajecia zajecia = new Zajecia();
                zajecia.NazwaZajec = sqlReader["NazwaZajec"].ToString();
                treningList.Add(zajecia);
            }
            con.Close();
            return treningList;
        }

        public void Dodaj_Kwote_Treningu( DateTime GodzRozp, double Kwota, int IdKlient, int IdTrener)
        {
            BazaDAO baza = new BazaDAO();
            string query = "update Trening set Kwota = '" + Kwota + "' where DataGodzRozp='" + GodzRozp + "',IdKlient ='" + IdKlient + "', IdTrener= '" + IdTrener + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();
        }

        public double Raport_Miesieczny(string dataPoczatkowa, string dataKoncowa, string LoginTrenera)
        {
            BazaDAO baza = new BazaDAO();
            string query = "select sum(t.Kwota) from Trening as t join Trener as tr on t.IdTrener = tr.IdTrener where (t.DataGodzZak between @datapoczatkowa and @datakoncowa ) and tr.Login = @login";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@datapoczatkowa", dataPoczatkowa));
            cmd.Parameters.Add(new SqlParameter("@datapoczatkowa", dataKoncowa));
            cmd.Parameters.Add(new SqlParameter("@login", LoginTrenera));
            sqlReader = cmd.ExecuteReader();
            var suma = sqlReader["Suma"].ToString();
            var d = Double.Parse(suma);
            return d;
        }

        public double Raport_Roczny(string Rok, string LoginTrenera)
        {
            BazaDAO baza = new BazaDAO();
            string query = "select sum(t.Kwota) from Trening as t join Trener as tr on t.IdTrener = tr.IdTrener where (t.DataGodzZak between @datapoczatkowa and @datakoncowa ) and tr.Login = @login";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@datapoczatkowa", Rok));
           
            cmd.Parameters.Add(new SqlParameter("@login", LoginTrenera));
            sqlReader = cmd.ExecuteReader();
            var suma = sqlReader["Suma"].ToString();
            var d = Double.Parse(suma);
            return d;
        }

        public List<Zajecia> Pobierz_Treningi_Klient(string Pesel)
        {
            List<Zajecia> treningList = new List<Zajecia>();
            BazaDAO baza = new BazaDAO();
            string query = "select z.NazwaZajec from Trening as t join Zajecia as z on t.IdTrening = z.IdTrening join Klient as k on t.IdKlient = k.IdKlient where k.Pesel = @pesel";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@pesel", Pesel));

            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Zajecia zajecia = new Zajecia();
                zajecia.NazwaZajec = sqlReader["NazwaZajec"].ToString();
                treningList.Add(zajecia);
            }
            con.Close();
            return treningList;
        }
    }
}

using ClassLibrary.Basic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class KlienciDAO : BazaDAO
    {
        public void Dodaj_Klienta(Klient klient, string LoginTrenera)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Insert Into Klient(Imie,Nazwisko,Pesel,Adres,Telefon,Email,Plec) Values(@imie,@nazwisko,@pesel,@adres,@telefon,@email,@plec)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@imie", klient.Imie));
            cmd.Parameters.Add(new SqlParameter("@nazwisko", klient.Nazwisko));
            cmd.Parameters.Add(new SqlParameter("@pesel", klient.Pesel));
            cmd.Parameters.Add(new SqlParameter("@adres", klient.Adres));
            cmd.Parameters.Add(new SqlParameter("@telefon", klient.Telefon));
            cmd.Parameters.Add(new SqlParameter("@email", klient.Email));
            cmd.Parameters.Add(new SqlParameter("@plec", klient.Plec));
            con.Close();

        }

        public void Modyfikuj_Klienta(Klient klient, string StaryPesel)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Update Klient set Imie='"+klient.Imie+"', Nazwisko='" + klient.Nazwisko + "', Pesel='" + klient.Pesel + "', Adres='" + klient.Adres + "',Telefon='" + klient.Telefon + "',Email='" + klient.Email + "',Plec='" + klient.Plec + "' where Pesel='" + klient.Pesel + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();

        }

        public List<Klient> Wyszukaj_Klient(string Pesel)
        {
            List<Klient> klientList = new List<Klient>();
            BazaDAO baza = new BazaDAO();
            string query = "Select * from Klient where Pesel = @pesel";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@pesel", Pesel));
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Klient klient = new Klient();
                klient.Imie = sqlReader["Imie"].ToString();
                klient.Nazwisko = sqlReader["Nazwisko"].ToString();
                klient.Pesel = sqlReader["Pesel"].ToString();
                klient.Adres = sqlReader["Adres"].ToString();
                klient.Telefon = sqlReader["Telefon"].ToString();
                klient.Email = sqlReader["Email"].ToString();
                klient.Plec = sqlReader["Plec"].ToString();
                klientList.Add(klient);
            }
            con.Close();
            return klientList;
        }

        public List<Klient> Pob_Wsz_Klienci(string Pesel, string nazwisko)
        {
            List<Klient> klientList = new List<Klient>();
            BazaDAO baza = new BazaDAO();
            string query = "Select * from Klient ";
            SqlCommand cmd = new SqlCommand(query, con);

            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Klient klient = new Klient();
                klient.Imie = sqlReader["Imie"].ToString();
                klient.Nazwisko = sqlReader["Nazwisko"].ToString();
                klient.Pesel = sqlReader["Pesel"].ToString();
                klient.Adres = sqlReader["Adres"].ToString();
                klient.Telefon = sqlReader["Telefon"].ToString();
                klient.Email = sqlReader["Email"].ToString();
                klient.Plec = sqlReader["Plec"].ToString();
                klientList.Add(klient);
            }
            con.Close();
            return klientList;
        }

        public void Dodaj_Zdjecie(string adresZdjecia, int IdKlient, DateTime dataZrobienia)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Insert into Zdjecia(IdKlient, AdresZdjecia, DataZrobienia) values(@IdKlient, @adresZdjecia, @dataZrobienia)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@IdKlient", IdKlient));
            cmd.Parameters.Add(new SqlParameter("@adresZdjecia", adresZdjecia));
            cmd.Parameters.Add(new SqlParameter("@dataZrobienia", dataZrobienia));
            con.Close();

        }

        public Zdjecie Pobierz_Zdjecie(Zdjecie zdjecie,int IdKlient)
        {
            
            BazaDAO baza = new BazaDAO();
            string query = "Select AdresZdjecia from Zdjecia where IdKlient = @IdKlient";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@IdKlient", IdKlient));
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                zdjecie.Zdjecia = sqlReader.ToString();
            }

            return zdjecie;
        }
    }
}

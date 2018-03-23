using ClassLibrary.Basic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class DodajUzytkownikaDAO: BazaDAO
    {
        
        public void Dodaj_Administrator(Administrator administrator)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Insert Into Administrator(Imie,Nazwisko,Login,Haslo) values(@imie,@nazwisko,@login,@haslo)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@imie", administrator.Imie));
            cmd.Parameters.Add(new SqlParameter("@nazwisko", administrator.Nazwisko));
            cmd.Parameters.Add(new SqlParameter("@login", administrator.Login));
            cmd.Parameters.Add(new SqlParameter("@haslo", administrator.Haslo));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Dodaj_Trener(Trener trener)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Insert Into Trener(Imie,Nazwisko,Login,Haslo) values(@imie,@nazwisko,@login,@haslo)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@imie", trener.Imie));
            cmd.Parameters.Add(new SqlParameter("@nazwisko", trener.Nazwisko));
            cmd.Parameters.Add(new SqlParameter("@login", trener.Login));
            cmd.Parameters.Add(new SqlParameter("@haslo", trener.Haslo));
            con.Close();
        }

        public void Dodaj_Recepcja(Recepcja recepcja)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Insert Into Recepcja(Imie,Nazwisko,Login,Haslo) values(@imie,@nazwisko,@login,@haslo)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@imie", recepcja.Imie));
            cmd.Parameters.Add(new SqlParameter("@nazwisko", recepcja.Nazwisko));
            cmd.Parameters.Add(new SqlParameter("@login", recepcja.Login));
            cmd.Parameters.Add(new SqlParameter("@haslo", recepcja.Haslo));
            con.Close();
        }

        public void Modyfikuj_Administrator(Administrator administrator, string StaryLogin)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Update Administrator set Imie='" + administrator.Imie + "', Nazwisko='" + administrator.Nazwisko + "', Login='" + administrator.Login + "', Hasło='" + administrator.Haslo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();
        }

        public void Modyfikuj_Trener(Trener trener, string StaryLogin)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Update Trener set Imie='" + trener.Imie + "', Nazwisko='" + trener.Nazwisko + "', Login='" + trener.Login + "', Hasło='" + trener.Haslo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();
        }

        public void Modyfikuj_Recepcja(Recepcja recepcja, string StaryLogin)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Update Recepcja set Imie='" + recepcja.Imie + "', Nazwisko='" + recepcja.Nazwisko + "', Login='" + recepcja.Login + "', Hasło='" + recepcja.Haslo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();
        }
    }
}

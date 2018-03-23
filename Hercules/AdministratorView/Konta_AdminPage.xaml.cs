using ClassLibrary;
using ClassLibrary.DAO;
using Hercules.Klasy;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using ClassLibrary.Basic;
namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy Konta_AdminPage.xaml
    /// </summary>
    public partial class Konta_AdminPage : Page
    {
        public Konta_AdminPage()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void addUserBtn_Click(object sender, RoutedEventArgs e)
        {
           //Nie dodaje użytkownika
            try
            {
                Metody metody = new Metody();

                BazaDAO baza = new BazaDAO();
                if (stanowiskoCB.Text == "Administrator")
                {
                    Administrator administrator = new Administrator();
                    administrator.Imie = imieTB.Text;
                    administrator.Nazwisko = nazwiskoTB.Text;
                    administrator.Login = loginTB.Text;
                    administrator.Haslo = hasloTB.Text;
                    metody.Dodaj_Administratora(administrator);
                    MessageBox.Show("Dodano użytkownika");
                }
                else if (stanowiskoCB.Text == "Trener")
                {
                    
                    Trener trener = new Trener();
                    trener.Imie = imieTB.Text;
                    trener.Nazwisko = nazwiskoTB.Text;
                    trener.Login = loginTB.Text;
                    trener.Haslo = hasloTB.Text;
                    metody.Dodaj_Trener(trener);
                    MessageBox.Show("Dodano użytkownika");
                }
                else if (stanowiskoCB.Text == "Recepcja")
                {
                    Recepcja recepcja = new Recepcja();
                    recepcja.Imie = imieTB.Text;
                    recepcja.Nazwisko = nazwiskoTB.Text;
                    recepcja.Login = loginTB.Text;
                    recepcja.Haslo = hasloTB.Text;
                    metody.Dodaj_Recepcja(recepcja);
                    MessageBox.Show("Dodano użytkownika");
                }
            }
            catch (Exception)
            {

                
            }
           


        }

        private void LoadDataBtn_Click(object sender, RoutedEventArgs e)
        {
            var connectionString = @"Data Source=RAFAL-PC;initial catalog=FITNES;integrated security=True";
            using (var con = new SqlConnection(connectionString))
            {

                if (adminRB.IsChecked == true)
                {
                    con.Open();
                    string query = "select Login from Administrator";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        kontoCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                    
                }
                else if (trenerRB.IsChecked == true)
                {
                    con.Open();
                    string query = "select * from Trener";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        kontoCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                }
                else if (recepcjaRB.IsChecked == true)
                {
                    con.Open();
                    string query = "select * from Recepcja";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        kontoCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                }
                

                
            }
        }

        private void changeDataBTN_Click(object sender, RoutedEventArgs e)
        {
            Pracownik pracownik = new Pracownik();
            try
            {
                var connectionString = @"Data Source=RAFAL-PC;initial catalog=FITNES;integrated security=True";
                using (var con = new SqlConnection(connectionString))
                {
                    pracownik.Login = kontoCB.Text;
                    string baza;
                    if (adminRB.IsChecked == true)
                    {
                        baza = "Administrator";
                    }
                    else if (trenerRB.IsChecked == true)
                    {
                        baza = "Trener";
                    }
                    else if (recepcjaRB.IsChecked == true)
                    {
                        baza = "Recepcja";
                    }
                    DataTable dt = new DataTable();
                    //con.Open();
                    //SqlDataReader myReader = null;
                    //SqlCommand myCommand = new SqlCommand("");
                    string query = "Select Imie, Nazwisko, Login, Haslo from @baza Where Login = @login";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.Parameters.Add(new SqlParameter("@baza", baza));
                    cmd.Parameters.Add(new SqlParameter("@login", kontoCB.Text));
                    // dowiedzieć się jak dane wrzucić do textbox z bazy
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

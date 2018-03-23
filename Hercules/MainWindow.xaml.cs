using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using ClassLibrary.DAO;

namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cboxPermissions.ItemsSource = LoadComboBoxData();
          
        }
        private string [] LoadComboBoxData() //data to combobox
        {
            string[] strArray =
            {
                "Administrator",
                "Trener",
                "Recepcja"
            };
            return strArray;
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            //Podłączenie do bazy danych
            LogowanieDAO logowanie = new LogowanieDAO();
            var i = logowanie.LogowanieAdministrator(tbxLogin.Text, pbPassword.Password.ToString(), cboxPermissions.Text);


            #region First_version
            //try
            //{
            //    var connectionString = @"Data Source=RAFAL-PC;initial catalog=FITNES;integrated security=True";  //Łączenie do bazy danych
            //    using (var con = new SqlConnection(connectionString))
            //    {
            //        con.Open();
            //        string txtUser = tbxLogin.Text;
            //        string txtPasswd = pbPassword.Password.ToString();
            //        string cbPermission = cboxPermissions.Text;

            //        string query = "SELECT * FROM Konta WHERE Login=@user AND Haslo=@paswd AND Przywileje=@perm";
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        cmd.Parameters.Add(new SqlParameter("@user", txtUser));
            //        cmd.Parameters.Add(new SqlParameter("@paswd", txtPasswd));
            //        cmd.Parameters.Add(new SqlParameter("@perm", cbPermission));
            //        SqlDataReader dr = cmd.ExecuteReader();

            //        if (dr.HasRows == true)
            //        {

            //            if (cbPermission == "Trener")
            //            {
            //                trener tr = new trener();
            //                tr.Show();


            //            }
            //            else if (cbPermission == "Recepcja")
            //            {
            //                recepcja rc = new recepcja();
            //                rc.Show();

            //            }
            //            else
            //            {
            //                administrator ad = new administrator();
            //                ad.Show();


            //            }
            //            con.Close();

            //        }
            //        else
            //        {
            //            MessageBox.Show("Invalid Login");
            //        }

            //        this.Close();
            //        /*
            //         * Na tą chwile działa podłączenie.
            //         * Pojawia się już okno prawidłowo
            //         * Okna pojawiają się w zależności od pracownika
            //           */


            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            #endregion


            if (i == 1)
            {
                trener tr = new trener();
                tr.Show();
            }
            else if (i == 2)
            {
                recepcja rc = new recepcja();
                rc.Show();
            }
            else if (i == 3)
            {
                administrator ad = new administrator();
                ad.Show();
            }





            base.OnClosed(e);






        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}

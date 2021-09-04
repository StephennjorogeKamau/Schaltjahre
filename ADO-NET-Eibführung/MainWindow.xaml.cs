using System;
using System.Data.SqlClient;
using System.Windows;

namespace ADO_NET_Eibführung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //
        string conStr = "Data Source=((localdb)\\MSSQLLocalDB);DataBase = Mitarbeiterprojekt.mdf; Connect Timeout=30;Integrated Security=true";

        public MainWindow()
        {
            InitializeComponent();
        }
        //DATABASE anfragen
        private void btAbfrage_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            

            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return;
            }
            finally
            {
                con.Close();
            }
        }

       
    }
}

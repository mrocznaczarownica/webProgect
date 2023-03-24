using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace webProgect.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientServicePage.xaml
    /// </summary>
    public partial class ClientServicePage : Page
    {
        public ClientServicePage()
        {
            InitializeComponent();

            DataTable dt = DataBaseConnection.ExecuteSql($"SELECT * FROM [dbo].[service_s_import]");
            clientServDataGrid.DataContext = DataBaseConnection.Select("SELECT * FROM [dbo].[service_s_import]");
            clientServDataGrid.ItemsSource = DataBaseConnection.Select("SELECT * FROM [dbo].[service_s_import]").DefaultView;
        }
    }
}

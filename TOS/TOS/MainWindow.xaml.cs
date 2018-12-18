using SQLitePCL;
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

namespace TOS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StructureButton_Click(object sender, RoutedEventArgs e)
        {
            /*using (var conn = new SQLiteConnection("Storage.db"))
            {
                string sql = @"CREATE TABLE IF NOT EXISTS People (
                                                ID INTEGER NOT NULL PRIMARY KEY,
                                                FirstName NVARCHAR(50),
                                                LastName NVARCHUAR(50));";
                using (var statement = conn.Prepare(sql))
                {
                    statement.Step();
                }
            }*/

            ff.Text = null;

            using (var conn = new SQLiteConnection("Storage.db"))
            {
                using (var statement = conn.Prepare("INSERT INTO People (FirstName, LastName) VALUES ('Конек', 'Горбунок')"))
                {
                    statement.Step();
                }
            }

            using (var conn = new SQLiteConnection("Storage.db"))
            {
                using (var statement = conn.Prepare("SELECT LastName, FirstName FROM People"))
                {
                    while (statement.Step() == SQLiteResult.ROW)
                    {
                        ff.Text = ff.Text + (string)statement[0] + Environment.NewLine;
                    }
                }
            }
        }
    }
}

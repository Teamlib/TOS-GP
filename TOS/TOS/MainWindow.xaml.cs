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

        private void Tos1_Selected(object sender, RoutedEventArgs e)
        {
            using (var conn = new SQLiteConnection("TOSBase.mdf"))

            using (var statement = conn.Prepare("SELECT chairman FROM tos_info WHERE tos_name='ТОС Петровского микрорайона'"))
            {
                while (statement.Step() == SQLiteResult.ROW)
                {
                    Pred.Text = Pred.Text + (string)statement[0];
                }
            }
        }
    }
}

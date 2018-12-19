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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {         
            combobox.SelectedIndex = 0;
            Pred.Text = null;
            selectedTos();      
        }

        string name;
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedTos();
        }

        public void selectedTos()
        {
            name = ((ComboBoxItem)combobox.SelectedItem).Content.ToString();
            if (tos1.IsSelected)
            {
                using (var conn = new SQLiteConnection("TT.db"))
                {
                    using (var statement = conn.Prepare("SELECT chairman FROM tos_info WHERE tos_name= '" + name + "'"))
                    {
                        while (statement.Step() == SQLiteResult.ROW)
                        {
                            Pred.Text = "Председатель: " + (string)statement[0];
                        }
                    }
                }
            }
            else if (tos2.IsSelected)
            {
                using (var conn = new SQLiteConnection("TT.db"))
                {
                    using (var statement = conn.Prepare("SELECT chairman FROM tos_info WHERE tos_name='" + name + "'"))
                    {
                        while (statement.Step() == SQLiteResult.ROW)
                        {
                            Pred.Text = "Председатель: " + (string)statement[0];
                        }
                    }
                }
            }
            else if (tos3.IsSelected)
            {
                using (var conn = new SQLiteConnection("TT.db"))
                {
                    using (var statement = conn.Prepare("SELECT chairman FROM tos_info WHERE tos_name='" + name + "'"))
                    {
                        while (statement.Step() == SQLiteResult.ROW)
                        {
                            Pred.Text = "Председатель: " + (string)statement[0];
                        }
                    }
                }
            }
            else if (tos4.IsSelected)
            {
                using (var conn = new SQLiteConnection("TT.db"))
                {
                    using (var statement = conn.Prepare("SELECT chairman FROM tos_info WHERE tos_name='" + name + "'"))
                    {
                        while (statement.Step() == SQLiteResult.ROW)
                        {
                            Pred.Text = "Председатель: " + (string)statement[0];
                        }
                    }
                }
            }
            else if (tos5.IsSelected)
            {
                using (var conn = new SQLiteConnection("TT.db"))
                {
                    using (var statement = conn.Prepare("SELECT chairman FROM tos_info WHERE tos_name='" + name + "'"))
                    {
                        while (statement.Step() == SQLiteResult.ROW)
                        {
                            Pred.Text = "Председатель: " + (string)statement[0];
                        }
                    }
                }
            }
            else if (tos6.IsSelected)
            {
                using (var conn = new SQLiteConnection("TT.db"))
                {
                    using (var statement = conn.Prepare("SELECT chairman FROM tos_info WHERE tos_name='" + name + "'"))
                    {
                        while (statement.Step() == SQLiteResult.ROW)
                        {
                            Pred.Text = "Председатель: " + (string)statement[0];
                        }
                    }
                }
            }
            else if (tos7.IsSelected)
            {
                using (var conn = new SQLiteConnection("TT.db"))
                {
                    using (var statement = conn.Prepare("SELECT chairman FROM tos_info WHERE tos_name='" + name + "'"))
                    {
                        while (statement.Step() == SQLiteResult.ROW)
                        {
                            Pred.Text = "Председатель: " + (string)statement[0];
                        }
                    }
                }
            }
            else if (tos8.IsSelected)
            {
                using (var conn = new SQLiteConnection("TT.db"))
                {
                    using (var statement = conn.Prepare("SELECT chairman FROM tos_info WHERE tos_name='" + name + "'"))
                    {
                        while (statement.Step() == SQLiteResult.ROW)
                        {
                            Pred.Text = "Председатель: " + (string)statement[0];
                        }
                    }
                }
            }
            else if (tos9.IsSelected)
            {
                using (var conn = new SQLiteConnection("TT.db"))
                {
                    using (var statement = conn.Prepare("SELECT chairman FROM tos_info WHERE tos_name='" + name + "'"))
                    {
                        while (statement.Step() == SQLiteResult.ROW)
                        {
                            Pred.Text = "Председатель: " + (string)statement[0];
                        }
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fm.NavigationService.Navigate(new Uri("StructurePage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

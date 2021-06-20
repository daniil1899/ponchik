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
using System.Windows.Shapes;

namespace ponyyy
{
    /// <summary>
    /// Логика взаимодействия для Agents.xaml
    /// </summary>
    public partial class Agents : Window
    {
        public Agents()
        {
            InitializeComponent();
            DAgents.ItemsSource = new sessionsEntities().lands.ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Workers workers = new Workers();
            workers.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
            Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddEdit addEdit = new AddEdit();
            addEdit.Show();
            Hide();
        }
    }
}

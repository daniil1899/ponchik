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

namespace ponyyy
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

        //Прописываем кнопку,чтобы она при нажатии октрывало окно Manager, и скрываем главное окно
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
            Hide();
        }
    }
}

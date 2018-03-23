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

namespace TCC_ETEC_2018
{
    /// <summary>
    /// Lógica interna para Calendario.xaml
    /// </summary>
    public partial class Calendario : Window
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow jan2 = new MainWindow();
            jan2.Show();

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Calendario jan2 = new Calendario();
            jan2.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
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
using Aplicacion_Gym.Clases;

namespace Aplicacion_Gym
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            this.Datos.ItemsSource = new Conexion().Result("select * from clientes");
        }

        public void Agregar(object sender, RoutedEventArgs e)
        {
            new Registro().Show();
            this.Close();
            
        }
        public void Refrescar(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Refrescar");
        }
        public void Eliminar(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Eliminar");
        }
        /*
        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Grid");
            
        }

        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Grid");
        }
        */

    }
}

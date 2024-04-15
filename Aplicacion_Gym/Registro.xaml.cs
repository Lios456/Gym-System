using Aplicacion_Gym.Clases;
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

namespace Aplicacion_Gym
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public Usuarios usuarios = new Usuarios();
        public Registro()
        {
            InitializeComponent();
            this.Nombre.Text = "gray";
            this.DataContext = usuarios;
            this.fecha.DisplayDateEnd = DateTime.Now;
            this.fecha.SelectedDate = DateTime.Now;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Usuarios.Registrar(usuarios);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}

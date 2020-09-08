using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;
namespace Vistas
{
    /// <summary>
    /// Interaction logic for MiMenu.xaml
    /// </summary>
    public partial class MiMenu : Window
    {
        public MiMenu()
        {
            InitializeComponent();
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            WinPelicula oPelicula = new WinPelicula();
            oPelicula.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MenuProyecciones menuProyecciones = new MenuProyecciones();
            menuProyecciones.Show();
            this.Close();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MenuButaca menuButaca = new MenuButaca();
            menuButaca.Show();
            this.Close();        }
    }
}

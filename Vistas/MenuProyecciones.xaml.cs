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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para MenuProyecciones.xaml
    /// </summary>
    public partial class MenuProyecciones : Window
    {
        public MenuProyecciones()
        {
            InitializeComponent();
        }

		private void MPeli_Click(object sender, RoutedEventArgs e)
		{
			Pelicula wPelicula = new Pelicula();
			wPelicula.Show();
			this.Close();
		}

		private void MButaca_Click(object sender, RoutedEventArgs e)
		{
			MenuButaca wButaca = new MenuButaca();
			wButaca.Show();
			this.Close();
		}
	}
}

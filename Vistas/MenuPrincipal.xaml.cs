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
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

		private void BtnPelicula_Click(object sender, RoutedEventArgs e)
		{
			Pelicula wPelicula = new Pelicula();
			wPelicula.Show();
			this.Close();

		}

		private void BtnButaca_Click(object sender, RoutedEventArgs e)
		{
			MenuButaca wButaca = new MenuButaca();
			wButaca.Show();
			this.Close();
		}

		private void BtnProyecciones_Click(object sender, RoutedEventArgs e)
		{
			MenuProyecciones wProyecciones = new MenuProyecciones();
			wProyecciones.Show();
			this.Close();
		}
	}
}

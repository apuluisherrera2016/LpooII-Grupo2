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
    /// Lógica de interacción para Pelicula.xaml
    /// </summary>
    public partial class WinPelicula : Window
    {
        public WinPelicula()
        {
            InitializeComponent();

        }

        public void cargarLista()
        {
            Usuario usuario = new Usuario();
           
            List<Pelicula> lista = new List <Pelicula>();
            Pelicula miPelicula = new Pelicula();
           
           
        }
        private void DgPelicula_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Pelicula oPelicula = new Pelicula();

            
        }

		private void MAtras_Click(object sender, RoutedEventArgs e)
		{
			MenuPrincipal mMain = new MenuPrincipal();
			mMain.Show();
			this.Close();
		}

		private void BntNuevoFilms_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}

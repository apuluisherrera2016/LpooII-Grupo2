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
    /// Interaction logic for AsignacionDeButacas.xaml
    /// </summary>
    public partial class AsignacionDeButacas : Window
    {
        public AsignacionDeButacas()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Button botonButaca = (Button)GridButacas.FindName("B3"); // creamos una variable botonButaca,FindName buscamos en la grilla(GridButacas) un elemento llamado B3 
            botonButaca.Background = Brushes.Red;

        }

        private void botonButaca_Click(object sender, RoutedEventArgs e)
        {
            Button botonButaca = (Button)sender; 
            if (botonButaca.Background != Brushes.Red)
            {
                if (botonButaca.Background == Brushes.LightGray)
                {
                    botonButaca.Background = Brushes.Green;
                }
                else
                {
                    botonButaca.Background = Brushes.LightGray;
                }

             }
                                
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

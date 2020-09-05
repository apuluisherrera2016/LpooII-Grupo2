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
    /// Lógica de interacción para MenuButaca.xaml
    /// </summary>
    public partial class MenuButaca : Window
    {
        public MenuButaca()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuProyecciones menuProyecciones = new MenuProyecciones();
            menuProyecciones.Show();
            this.Close();
        }
    }
}

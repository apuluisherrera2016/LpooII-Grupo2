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
    /// Interaction logic for login1.xaml
    /// </summary>
    public partial class login1 : Window
    {
        public login1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text == "admin" )
            {
                MiMenu menuAdmin = new MiMenu();
                menuAdmin.Show();
                this.Close();
            }
            else
                lblError.Content = lblError.Content + "Datos incorrectos";
        }
    }
}

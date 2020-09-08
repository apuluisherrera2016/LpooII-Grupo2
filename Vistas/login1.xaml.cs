using ClasesBase;
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
        Usuario adminUsuario = new Usuario();
        Usuario unVendedor = new Usuario();



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
            adminUsuario.Usu_Username = "admin";
            adminUsuario.Usu_Password = "admin";
            unVendedor.Usu_Username = "vendedor";
            unVendedor.Usu_Password = "vendedor";

            String pass = pwbContraseña.Password.ToString();
            if (txtUsuario.Text.Equals( adminUsuario.Usu_Username) && pass.Equals(adminUsuario.Usu_Password) )
            {
                
                   MenuPrincipal  menuUsuario = new MenuPrincipal();
                    menuUsuario.Show();
                    this.Close();
                
            }

            else

            {
                if(txtUsuario.Text.Equals(unVendedor.Usu_Username) && pass.Equals(unVendedor.Usu_Password))
                {
                    menuVendedor unVendedor = new menuVendedor();
                    unVendedor.Show();
                    this.Close();
                }
                else
                {
                    lblError.Content = lblError.Content + "datos incorectos";
                }
            }
        }

       

        
    }
}

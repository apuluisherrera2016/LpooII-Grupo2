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
    /// Lógica de interacción para MenuVendedor.xaml
    /// </summary>
    public partial class MenuVendedor : Window
    {
        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void mainCliente_Click(object sender, RoutedEventArgs e)
        {
            Clientes vClientes = new Clientes();
            vClientes.Show();
            this.Close();
        }

        private void menuBtnTicket_Click(object sender, RoutedEventArgs e)
        {
            Tickets wTicket = new Tickets();
            wTicket.Show();
            this.Close();
        }
    }
}

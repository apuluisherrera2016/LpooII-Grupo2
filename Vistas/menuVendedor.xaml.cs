﻿using System;
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
    /// Lógica de interacción para menuVendedor.xaml
    /// </summary>
    public partial class menuVendedor : Window
    {
        public menuVendedor()
        {
            InitializeComponent();
        }

		private void MainCliente_Click(object sender, RoutedEventArgs e)
		{
			ABMClientes winCliente = new ABMClientes();
			winCliente.Show();
			this.Close();
		}
	}
}

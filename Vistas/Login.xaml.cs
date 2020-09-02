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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            MenuVendedor wVendedor = new MenuVendedor();
            MenuAdmin wMadmin = new MenuAdmin();

            if((txtUser.Text !="") &&(passwordBox.Password != ""))
            {
                if ((txtUser.Text == "admin") && (passwordBox.Password == "admin"))
                {
                    wMadmin.Show();
                    this.Close();


                }
                else
                {
                    if ((txtUser.Text == "vendedor") && (passwordBox.Password == "vendedor"))
                        wVendedor.Show();
                    this.Close();
                    
                }
            }
            else 
                   MessageBox.Show("DATOS INCORRECTOS");
        }
    }
}

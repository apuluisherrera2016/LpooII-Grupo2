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
	/// Lógica de interacción para Cliente.xaml
	/// </summary>
	public partial class ABMClientes : Window
	{
		public ABMClientes()
		{
			InitializeComponent();
		}
		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("Desea guardar los datos cargados?", "CONFIRMACION", MessageBoxButton.YesNo);
			if (result == MessageBoxResult.Yes)
			{
				Cliente oCliente = new Cliente();
				oCliente.Cli_Dni = int.Parse(txtDNI.Text);
				oCliente.Cli_Nombre = txtNombre.Text;
				oCliente.Cli_Apellido = txtApellido.Text;
				oCliente.Cli_Telefono = txtTelefono.Text;
				oCliente.Cli_Email = txtEmail.Text;

				MessageBox.Show("Se guardaron los siguiente datos: \n" +
					"\n DNI: " + oCliente.Cli_Dni.ToString() +
					"\n NOMBRE: " + oCliente.Cli_Nombre +
					"\n APELLIDO: " + oCliente.Cli_Apellido +
					"\n TELEFONO: " + oCliente.Cli_Telefono +
					"\n EMAIL: " + oCliente.Cli_Email);

				LimpiarCampoCliente();

			}
		}

		private void LimpiarCampoCliente()
		{
			txtDNI.Clear();
			txtNombre.Clear();
			txtApellido.Clear();
			txtTelefono.Clear();
			txtEmail.Clear();
		}

		private void btnCancelar_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}

}


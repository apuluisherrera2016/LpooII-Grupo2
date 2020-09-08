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
	/// Lógica de interacción para Asignacion_de_Butacas.xaml
	/// </summary>
	public partial class Asignacion_de_Butacas : Window
	{
		public Asignacion_de_Butacas()
		{
			InitializeComponent();
		}
		void OnClick1(object sender, RoutedEventArgs e)
		{
			btn1.Background = Brushes.LightBlue;
		}

		void OnClick2(object sender, RoutedEventArgs e)
		{
			btn2.Background = Brushes.Pink;
		}

		void OnClick3(object sender, RoutedEventArgs e)
		{
			btn1.Background = Brushes.Pink;
			btn2.Background = Brushes.LightBlue;
		}
	}
}

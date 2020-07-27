using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProzoriIProzori
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ObservableCollection<Osoba> listaOsoba = new ObservableCollection<Osoba>();

		public MainWindow()
		{
			InitializeComponent();
			dg.ItemsSource = listaOsoba;
		}

		private void Unos(object zxcasd, RoutedEventArgs zklj)
		{
			DrugiProzor np = new DrugiProzor();
			np.Owner = this;

			if (np.ShowDialog().Value)
				listaOsoba.Add(np.DataContext as Osoba);
		}

		private void Brisanje(object sender, RoutedEventArgs e)
		{
			listaOsoba.Remove(dg.SelectedItem as Osoba);
		}

		private void Promena(object sender, SelectionChangedEventArgs e)
		{
			if (dg.SelectedItem != null)  //Ne radi se ovako inace, samo za malenu demonstraciju :) 
			{
				brs.IsEnabled = true;
				izm.IsEnabled = true;
			}
			else
			{
				izm.IsEnabled = false;
				brs.IsEnabled = false;
			}

				   
		}

		private void Izmena(object sender, RoutedEventArgs e)
		{
			DrugiProzor np = new DrugiProzor();
			np.Owner = this;
			np.DataContext = dg.SelectedItem;
			np.ShowDialog();
		}
	}

	class Osoba
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
	}


}

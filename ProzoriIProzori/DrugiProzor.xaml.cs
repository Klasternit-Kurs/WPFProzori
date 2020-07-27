using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ProzoriIProzori
{
	/// <summary>
	/// Interaction logic for DrugiProzor.xaml
	/// </summary>
	public partial class DrugiProzor : Window
	{

		public DrugiProzor()
		{
			InitializeComponent();
			DataContext = new Osoba();
			BindingGroup = new BindingGroup();
		}

		private void OK(object sender, RoutedEventArgs e)
		{
			DialogResult = true;
			BindingGroup.CommitEdit();
			Close();
		}

		private void Otkazi(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}

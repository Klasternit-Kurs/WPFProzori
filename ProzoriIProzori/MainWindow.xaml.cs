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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProzoriIProzori
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new Proba();
		}

		private void NoviProzor(object sender, RoutedEventArgs e)
		{
			DrugiProzor np = new DrugiProzor();
			np.DataContext = DataContext;
			np.Owner = this;
			np.ShowDialog();
			
		}
	}

	class Proba
	{
		public string Test { get; set; } = "to i to";
	}


}

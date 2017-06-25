using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using WinAir.Server.Views;

namespace WinAir.Server.Services
{
	public class NavigationService : INavigationService
	{
		public void NavigateToStartup()
		{
			App.Current.MainWindow.Content = new HomePage();
		}

		// TODO: remove
		public void NavigateToSample()
		{
			App.Current.MainWindow.Content = new SamplePage();
		}
	}
}

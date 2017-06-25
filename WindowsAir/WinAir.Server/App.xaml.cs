using System.Windows;
using WinAir.Server.Services;
using WinAir.Server.ViewModels;
using WinAir.Tools;

namespace WinAir.Server
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			var window = new Window()
			{
				Width = 525,
				Height = 350,
				Title = "Windows Air"
			};
			MainWindow = window;
			MainWindow.Show();

			RegisterIoC();

			IoC.GetInstance<INavigationService>().NavigateToStartup();
		}

		private void RegisterIoC()
		{
			IoC.RegisterSingleton<INavigationService, NavigationService>();
			IoC.Register<HomeViewModel>();
		}
	}
}

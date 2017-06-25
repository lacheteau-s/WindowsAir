using WinAir.Server.Services;

namespace WinAir.Server.ViewModels
{
	public class HomeViewModel : ViewModelBase
	{
		private INavigationService _navigationService;

		public HomeViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
		}
	}
}

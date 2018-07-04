using WinAir.Server.Services;

namespace WinAir.Server.ViewModels
{
	public class HomeViewModel : ViewModelBase
	{
		private INavigationService _navigationService;

		private INetworkService _networkService;

		public HomeViewModel(INavigationService navigationService, INetworkService networkService)
		{
			_navigationService = navigationService;
			_networkService = networkService;
		}
	}
}

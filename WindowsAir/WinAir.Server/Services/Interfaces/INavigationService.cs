using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAir.Server.Services
{
	public interface INavigationService
	{
		void NavigateToStartup();

		// TODO: remove
		void NavigateToSample();
	}
}

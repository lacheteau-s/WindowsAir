using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using WinAir.Server.ViewModels;
using WinAir.Tools;

namespace WinAir.Server.Views
{
	/// <summary>
	/// Type meant to be used as mother class for every page in the application.
	/// This class shouldn't have an associated XAML since WPF doesn't support using an XAML-defined class as the root element inside another XAML (e.g when inheriting)
	/// </summary>
	public class BasePage<T> : Page where T : ViewModelBase
	{
		private T _viewModel;

		public T ViewModel => _viewModel;

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			_viewModel = IoC.GetInstance<T>();
		}
	}
}

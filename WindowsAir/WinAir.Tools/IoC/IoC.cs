using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinAir.Tools
{
    public static class IoC
    {
		private static Container _container;

		private static Container Container
		{
			get
			{
				if (_container == null)
					_container = new Container();

				return _container;
			}
		}

		public static void Register<T>() where T : class
		{
			Container.Register<T>();
		}

		public static void RegisterSingleton<TInterface, TImplementation>() where TInterface : class where TImplementation : class, TInterface
		{
			Container.RegisterSingleton<TInterface, TImplementation>();
		}

		public static TService GetInstance<TService>() where TService : class
		{
			return Container.GetInstance<TService>();
		}
    }
}

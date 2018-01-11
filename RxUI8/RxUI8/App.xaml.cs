using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RxUI8
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            var bootStraper = new AppBootstrapper();
		    MainPage = bootStraper.CreateMainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

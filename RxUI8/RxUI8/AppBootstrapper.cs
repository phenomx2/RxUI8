using System;
using System.Diagnostics;
using ReactiveUI;
using ReactiveUI.XamForms;
using RxUI8.ViewModel;
using RxUI8.Views;
using Splat;
using Xamarin.Forms;

namespace RxUI8
{
    public class AppBootstrapper: ReactiveObject, IScreen
    {
        public RoutingState Router { get; }


        public AppBootstrapper()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant(this,typeof(IScreen));
            RegisterViews();
            RegisterViewModels();
            Router.Navigate.Execute(new LoginViewModel(this));
        }

        public Page CreateMainPage()
        {
            try
            {
                return new RoutedViewHost();
            }
            catch (Exception e)
            {
                Debugger.Break();
                throw;
            }
        }

        private void RegisterViewModels()
        {
            Locator.CurrentMutable.Register(() => new LoginViewModel(this), typeof(LoginViewModel));
        }

        private void RegisterViews()
        {
            Locator.CurrentMutable.Register(() => new Login(), typeof(Login));

        }
    }
}
using System.Reactive.Disposables;
using ReactiveUI;
using Splat;

namespace RxUI8.ViewModel
{
    public class ViewModelBase : ReactiveObject, IRoutableViewModel, ISupportsActivation
    {
        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }
        public ViewModelActivator Activator => ViewModelActivator;
        protected readonly ViewModelActivator ViewModelActivator = new ViewModelActivator();
        protected readonly CompositeDisposable DubscriptionDisposables = new CompositeDisposable();

        public ViewModelBase(IScreen hostScreen)
        {
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
            UrlPathSegment = string.Empty;
        }
    }
}
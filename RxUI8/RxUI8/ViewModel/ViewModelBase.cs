using ReactiveUI;

namespace RxUI8.ViewModel
{
    public class ViewModelBase : ReactiveObject, IScreen, IRoutableViewModel
    {
        public RoutingState Router { get; }

        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }
    }
}
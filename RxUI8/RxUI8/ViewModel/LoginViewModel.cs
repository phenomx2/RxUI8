using System.Reactive;
using ReactiveUI;

namespace RxUI8.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit,Unit> LoginCommand { get; set; }

        public LoginViewModel(IScreen hostScreen) : base(hostScreen)
        {
            LoginCommand = ReactiveCommand.Create<Unit,Unit>(_ =>
            {
                System.Diagnostics.Debug.WriteLine("Que onda");
                return Unit.Default;
            });

        }
    }
}
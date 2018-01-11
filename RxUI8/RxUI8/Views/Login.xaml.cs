using RxUI8.ViewModel;
using Xamarin.Forms.Xaml;

namespace RxUI8.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPageBase<LoginViewModel>
	{
		public Login ()
		{
			InitializeComponent ();
		}
	}
}
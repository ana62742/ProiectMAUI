using ProiectMAUI.Views;

namespace ProiectMAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(AddUpdateConcert), typeof(AddUpdateConcert));
	}
}

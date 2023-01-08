using ProiectMAUI.ViewModels;

namespace ProiectMAUI.Views;

public partial class AddUpdateConcert : ContentPage
{
	public AddUpdateConcert(AddUpdateConcertViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}
using ProiectMAUI.ViewModels;

namespace ProiectMAUI.Views;

public partial class ConcertListPage : ContentPage
{
    
    private ConcertListPageViewModel _viewMode;
    public ConcertListPage(ConcertListPageViewModel viewModel)
    {
        InitializeComponent();
        _viewMode = viewModel;
        this.BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewMode.GetConcertListCommand.Execute(null);
    }
}
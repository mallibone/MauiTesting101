using MauiDeviceTesting101.Core;

namespace MauiDeviceTesting101;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}



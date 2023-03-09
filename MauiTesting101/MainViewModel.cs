using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiTesting101;

public partial class MainViewModel : ObservableObject
{
	[ObservableProperty] private int _count;
	[ObservableProperty] private string _text = "Click me";

	[RelayCommand]
	public void CounterClicked()
	{
		Count++;

		if (Count == 1) Text = $"Clicked {Count} time";
		else Text = $"Clicked {Count} times";

	}
}


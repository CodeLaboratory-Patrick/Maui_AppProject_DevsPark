using System.Diagnostics;
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages;

public partial class AppShell : Shell
{
	public AppShell(PlacesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
	
	protected override void OnNavigated(ShellNavigatedEventArgs args)
	{
		base.OnNavigated(args);

		Debug.WriteLine($"--- A navigation was performed: {args.Source}, " +
		                $"from {args.Previous?.Location} to {args.Current?.Location}");

	}

	protected override void OnNavigating(ShellNavigatingEventArgs args)
	{
		base.OnNavigating(args);
	}
	
}
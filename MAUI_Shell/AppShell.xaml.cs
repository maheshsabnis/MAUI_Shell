namespace MAUI_Shell;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    private async void MenuItem_Clicked(object sender, EventArgs e)
    {
		await DisplayAlert("Info", "Hello Menu 1", "Close" );
    }
}

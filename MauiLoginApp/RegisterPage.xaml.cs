namespace MauiLoginApp;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private async void OnLoginLabelTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private void OnRegisterButtonClicked(object sender, EventArgs e)
    {

    }
}
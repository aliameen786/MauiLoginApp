using System.Threading.Tasks;

namespace MauiLoginApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnRegisterLabelTapped(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new RegisterPage());
    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
		if (string.IsNullOrEmpty(UsernameEntry.Text)  || string.IsNullOrEmpty(PasswordEntry.Text))
		{
			await DisplayAlert("Error", "Please enter both username and password", "ok");
			return;
		}

        if (UsernameEntry.Text == "user" && PasswordEntry.Text == "password")
        {
            await DisplayAlert("Success", "Login Successful!", "ok");
            await Navigation.PushAsync(new MainPage());
        }
        else {
            await DisplayAlert("Error", "Invalid username or password", "ok");
        }
    }
}
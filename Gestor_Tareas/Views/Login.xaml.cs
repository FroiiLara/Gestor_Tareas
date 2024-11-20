using Microsoft.Maui.Controls;
using Telerik.Maui.Controls;

namespace Gestor_Tareas.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent(); // Aseg�rate de que esto est� presente
        }

        // Evento que se ejecuta al hacer clic en el bot�n de "Iniciar sesi�n"
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Aqu� puedes validar las credenciales o realizar la autenticaci�n
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Por favor ingrese su usuario y contrase�a", "OK");
            }
            else
            {
                // L�gica de autenticaci�n
                if (username == "usuario" && password == "12345")
                {
                    await DisplayAlert("Bienvenido", "Inicio de sesi�n exitoso", "OK");

                    // Cambiar la MainPage a Home una vez el usuario ha iniciado sesi�n
                    Application.Current.MainPage = new NavigationPage(new Home());
                }
                else
                {
                    await DisplayAlert("Error", "Credenciales incorrectas", "OK");
                }
            }
        }

        // Evento para recuperar la contrase�a
        private async void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Recuperar Contrase�a", "Dirigi�ndote a la p�gina de recuperaci�n de contrase�a.", "OK");
        }
    }
}



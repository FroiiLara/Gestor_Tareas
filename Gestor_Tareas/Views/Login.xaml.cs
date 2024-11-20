using Microsoft.Maui.Controls;
using Telerik.Maui.Controls;

namespace Gestor_Tareas.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent(); // Asegúrate de que esto esté presente
        }

        // Evento que se ejecuta al hacer clic en el botón de "Iniciar sesión"
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Aquí puedes validar las credenciales o realizar la autenticación
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Por favor ingrese su usuario y contraseña", "OK");
            }
            else
            {
                // Lógica de autenticación
                if (username == "usuario" && password == "12345")
                {
                    await DisplayAlert("Bienvenido", "Inicio de sesión exitoso", "OK");

                    // Cambiar la MainPage a Home una vez el usuario ha iniciado sesión
                    Application.Current.MainPage = new NavigationPage(new Home());
                }
                else
                {
                    await DisplayAlert("Error", "Credenciales incorrectas", "OK");
                }
            }
        }

        // Evento para recuperar la contraseña
        private async void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Recuperar Contraseña", "Dirigiéndote a la página de recuperación de contraseña.", "OK");
        }
    }
}



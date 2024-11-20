namespace Gestor_Tareas.Views
{
    public partial class Programador : ContentPage
    {
        public Programador()
        {
            InitializeComponent();
        }

        // Evento para el bot�n Home
        private async void OnHomeClicked(object sender, EventArgs e)
        {
            // Navegar a la p�gina de inicio
            await Navigation.PopToRootAsync();
        }

        // Evento para el bot�n Crear Tarea
        private async void OnCrearTareaClicked(object sender, EventArgs e)
        {
            // Navegar a la p�gina de Crear Tarea
            await Navigation.PushAsync(new CrearTarea());
        }

        // Evento para el bot�n Consultar Tareas
        private async void OnConsultarTareasClicked(object sender, EventArgs e)
        {
            // Navegar a la p�gina de Consultar Tareas
            await Navigation.PushAsync(new ConsultarTareas());
        }
    }
}


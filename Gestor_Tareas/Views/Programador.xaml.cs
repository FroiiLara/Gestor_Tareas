namespace Gestor_Tareas.Views
{
    public partial class Programador : ContentPage
    {
        public Programador()
        {
            InitializeComponent();
        }

        // Evento para el botón Home
        private async void OnHomeClicked(object sender, EventArgs e)
        {
            // Navegar a la página de inicio
            await Navigation.PopToRootAsync();
        }

        // Evento para el botón Crear Tarea
        private async void OnCrearTareaClicked(object sender, EventArgs e)
        {
            // Navegar a la página de Crear Tarea
            await Navigation.PushAsync(new CrearTarea());
        }

        // Evento para el botón Consultar Tareas
        private async void OnConsultarTareasClicked(object sender, EventArgs e)
        {
            // Navegar a la página de Consultar Tareas
            await Navigation.PushAsync(new ConsultarTareas());
        }
    }
}


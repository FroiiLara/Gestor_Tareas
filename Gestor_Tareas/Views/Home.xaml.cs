using Microsoft.Maui.Controls;
using System;
using System.Timers;  // Aseguramos usar el Timer de System.Timers

namespace Gestor_Tareas.Views
{
    public partial class Home : ContentPage
    {
        private System.Timers.Timer _timer;  // Especificamos explícitamente el tipo completo

        // Constructor de la página
        [Obsolete]
        public Home()
        {
            InitializeComponent();  // Inicializa los componentes del XAML

            // Inicializar el temporizador
            _timer = new System.Timers.Timer(60000);  // 60000 milisegundos = 1 minuto
            _timer.Elapsed += OnTimerElapsed;  // Evento que se dispara cada vez que pasa 1 minuto
            _timer.Start();  // Iniciar el temporizador

            // Establecer la fecha al cargar la página
            FechaLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        // Evento que se dispara cada vez que pasa 1 minuto
        [Obsolete]
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Usamos InvokeOnMainThread para actualizar la UI desde el hilo del temporizador
            Device.BeginInvokeOnMainThread(() =>
            {
                FechaLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            });
        }

        // Método para navegar a la vista de Crear Tarea
        private async void OnCrearTareaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearTarea());
        }

        // Método para navegar a la vista de Consultar Tareas
        private async void OnConsultarTareasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultarTareas());
        }

        // Método para navegar a la vista de Programador
        private async void OnProgramadorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Programador());
        }

        // Detener el temporizador cuando la página desaparezca
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _timer.Stop();  // Detener el temporizador cuando la página desaparezca
        }
    }
}


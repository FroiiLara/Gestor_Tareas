using Gestor_Tareas.Models;
using Microsoft.Maui.Controls;
using Telerik.Maui.Controls;
using System;

namespace Gestor_Tareas.Views
{
    public partial class EditarTarea : ContentPage
    {
        public Tarea Tarea { get; set; }

        // Lista de posibles estados de la tarea
        public string[] Estados { get; } = new[] { "Pendiente", "En Progreso", "Completada" };

        public EditarTarea(Tarea tarea)
        {
            InitializeComponent();

            // Asignamos la tarea pasada como parámetro
            Tarea = tarea;

            // Establecemos el contexto de enlace de datos
            BindingContext = this;
        }

        // Comando para guardar los cambios realizados en la tarea
        public Command GuardarCambiosCommand => new Command(() =>
        {
            DisplayAlert("Éxito", "La tarea ha sido actualizada.", "OK");

            Navigation.PopAsync();  // Regresa a la página anterior (ConsultarTareas)
        });

        // Evento de cambio de selección del combo box de estado
        private void EstadoComboBox_SelectionChanged(object sender, EventArgs e)
        {
            var comboBox = sender as RadComboBox;
            var selectedItem = comboBox.SelectedItem;
            Console.WriteLine($"Estado seleccionado: {selectedItem}");
        }

        // Métodos de navegación para los botones
        private async void OnHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(); // Regresa a la página principal
        }

        private async void OnCrearTareaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearTarea()); // Navega a la página de Crear Tarea
        }

        private async void OnProgramadorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Programador()); // Navega a la página de Programador
        }
    }
}

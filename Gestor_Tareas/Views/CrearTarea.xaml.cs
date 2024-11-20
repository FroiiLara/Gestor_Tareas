using Microsoft.Maui.Controls;
using System;

namespace Gestor_Tareas.Views
{
    public partial class CrearTarea : ContentPage
    {
        public CrearTarea()
        {
            InitializeComponent();
        }

        private async void OnCrearTareaClicked(object sender, EventArgs e)
        {
            // Obtener los valores de los campos
            string nombreTarea = NombreTareaEntry.Text;
            string personaAsignada = PersonaAsignadaComboBox.SelectedItem?.ToString(); // Obtener la persona seleccionada
            string? prioridad = PrioridadComboBox.SelectedItem?.ToString();  // Obtener la prioridad seleccionada
            string? categoria = CategoriaComboBox.SelectedItem?.ToString();  // Obtener la categoría seleccionada
            string detallesTarea = DetallesTareaEditor.Text;

            // Obtener la fecha seleccionada
            DateTime? fechaSeleccionada = datePicker?.Date;  // Aquí usamos la propiedad Date

            // Validar que todos los campos estén completos
            if (string.IsNullOrEmpty(nombreTarea) ||
                string.IsNullOrEmpty(personaAsignada) ||
                string.IsNullOrEmpty(prioridad) ||
                string.IsNullOrEmpty(categoria) ||
                string.IsNullOrEmpty(detallesTarea) ||
                fechaSeleccionada == null)
            {
                await DisplayAlert("Error", "Por favor complete todos los campos.", "OK");
                return;
            }

            // Mostrar mensaje de éxito
            await DisplayAlert("Tarea Creada", "La tarea ha sido creada correctamente.", "OK");

            // Limpiar los campos después de la creación
            NombreTareaEntry.Text = string.Empty;
            PersonaAsignadaComboBox.SelectedIndex = -1; // Limpiar la selección del ComboBox
            PrioridadComboBox.SelectedIndex = -1; // Limpiar la selección del ComboBox
            CategoriaComboBox.SelectedIndex = -1; // Limpiar la selección del ComboBox
            DetallesTareaEditor.Text = string.Empty;
            datePicker.Date = null; // Limpiar la fecha seleccionada

        }
            private async void OnHomeClicked(object sender, EventArgs e)
        {
            // Aquí puedes navegar a la vista Home
            await Navigation.PopToRootAsync(); // Esto llevará al usuario de vuelta a la página principal (Home)
        }

        // Maneja el evento Clicked del botón Consultar Tareas
        private async void OnConsultarTareasClicked(object sender, EventArgs e)
        {
            // Aquí puedes navegar a la vista de Consultar Tareas
            await Navigation.PushAsync(new ConsultarTareas()); // Suponiendo que ConsultarTareas es otra página
        }

        // Maneja el evento Clicked del botón Programador
        private async void OnProgramadorClicked(object sender, EventArgs e)
        {
            // Aquí puedes navegar a la vista Programador
            await Navigation.PushAsync(new Programador()); // Suponiendo que Programador es otra página
        }
    }
    }



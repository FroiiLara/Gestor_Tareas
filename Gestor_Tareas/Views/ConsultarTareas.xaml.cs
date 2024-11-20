using Gestor_Tareas.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gestor_Tareas.Views
{
    public partial class ConsultarTareas : ContentPage
    {
        public List<Tarea> Tareas { get; set; }  // Lista completa de tareas
        public List<Tarea> TareasFiltradas { get; set; }  // Lista filtrada para el CollectionView

        public ConsultarTareas()
        {
            InitializeComponent();

            // Crear las tareas con los datos necesarios
            Tareas = new List<Tarea>
            {
                new Tarea
                {
                    NombreTarea = "Desarrollar nueva funcionalidad",
                    PersonaAsignada = "Juan Pérez",
                    Prioridad = "Alta",
                    Estado = "Pendiente",
                    Categoria = "Desarrollo",
                    DetallesTarea = "Desarrollar una nueva funcionalidad para la aplicación de gestión de tareas.",
                    FechaTarea = new DateTime(2024, 11, 10)
                },
                new Tarea
                {
                    NombreTarea = "Revisar el servidor",
                    PersonaAsignada = "Ana Gómez",
                    Prioridad = "Media",
                    Estado = "En Progreso",
                    Categoria = "Soporte",
                    DetallesTarea = "Revisar el estado de los servidores y realizar un mantenimiento preventivo.",
                    FechaTarea = new DateTime(2024, 11, 12)
                },

                new Tarea
                {
                    NombreTarea = "Actualizar base de datos",
                    PersonaAsignada = "Carlos Sánchez",
                    Prioridad = "Alta",
                    Estado = "Pendiente",
                    Categoria = "Desarrollo",
                    DetallesTarea = "Actualizar la base de datos para la nueva versión de la aplicación.",
                    FechaTarea = new DateTime(2024, 11, 15)
                },
                new Tarea
                {
                    NombreTarea = "Documentar API",
                    PersonaAsignada = "Laura Martínez",
                    Prioridad = "Baja",
                    Estado = "Completada",
                    Categoria = "Documentación",
                    DetallesTarea = "Crear la documentación de la API para el equipo de desarrollo.",
                    FechaTarea = new DateTime(2024, 11, 5)
                },
                new Tarea
                {
                    NombreTarea = "Pruebas de funcionalidad",
                    PersonaAsignada = "Pedro Rodríguez",
                    Prioridad = "Alta",
                    Estado = "En Progreso",
                    Categoria = "Desarrollo",
                    DetallesTarea = "Realizar pruebas de funcionalidad para verificar que todas las características estén operativas.",
                    FechaTarea = new DateTime(2024, 11, 8)
                },
                new Tarea
                {
                    NombreTarea = "Instalar nueva versión de software",
                    PersonaAsignada = "Sofía López",
                    Prioridad = "Media",
                    Estado = "Pendiente",
                    Categoria = "Soporte",
                    DetallesTarea = "Instalar la nueva versión de software en los servidores de producción.",
                    FechaTarea = new DateTime(2024, 11, 18)
                },
                new Tarea
                {
                    NombreTarea = "Reunión con el cliente",
                    PersonaAsignada = "Ricardo Fernández",
                    Prioridad = "Alta",
                    Estado = "Pendiente",
                    Categoria = "Administración",
                    DetallesTarea = "Tener una reunión con el cliente para revisar el avance del proyecto.",
                    FechaTarea = new DateTime(2024, 11, 20)
                }

            };

            // Inicializamos TareasFiltradas con la lista completa de tareas
            TareasFiltradas = new List<Tarea>(Tareas);

            // Vinculamos la lista de tareas filtradas al CollectionView
            BindingContext = this;
        }

        // Evento que se ejecuta cuando el texto del SearchBar cambia
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            // Obtener el texto ingresado en el SearchBar
            var searchText = e.NewTextValue?.ToLower() ?? string.Empty;

            if (string.IsNullOrEmpty(searchText))
            {
                // Si el SearchBar está vacío, mostramos todas las tareas
                TareasFiltradas = new List<Tarea>(Tareas);
            }
            else
            {
                // Filtrar las tareas por el nombre de la tarea, asegurándonos de que la búsqueda no distinga entre mayúsculas y minúsculas
                TareasFiltradas = Tareas.Where(t => t.NombreTarea.ToLower().Contains(searchText)).ToList();
            }

            // Notificamos que la lista de tareas filtradas ha cambiado
            OnPropertyChanged(nameof(TareasFiltradas));
        }

        // Comando que maneja la navegación hacia la página de edición
        public Command EditarTareaCommand => new Command<Tarea>(async (tarea) =>
        {
            // Navegar a la página de edición y pasar la tarea seleccionada
            await Navigation.PushAsync(new EditarTarea(tarea));
        });

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



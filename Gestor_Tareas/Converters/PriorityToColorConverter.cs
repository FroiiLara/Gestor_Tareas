using Microsoft.Maui.Controls;  // Para el IValueConverter
using Microsoft.Maui.Graphics;  // Para acceder a los colores predefinidos (Color.Red, Color.Yellow, etc.)
using System;
using System.Globalization;

namespace Gestor_Tareas.Converters
{
    public class PriorityToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string priority = value as string;

            // Convertir la prioridad en un color
            return priority switch
            {
                "Alta" => Colors.Red,     // Usar Colors.Red
                "Media" => Colors.Yellow, // Usar Colors.Yellow
                "Baja" => Colors.Green,   // Usar Colors.Green
                _ => Colors.Transparent   // Usar Colors.Transparent si la prioridad no es válida
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;  // No se necesita implementación para este caso
        }
    }
}


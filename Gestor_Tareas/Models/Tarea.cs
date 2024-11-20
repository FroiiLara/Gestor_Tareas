using System;

namespace Gestor_Tareas.Models
{
    public class Tarea
    {
        public required string NombreTarea { get; set; }
        public required string PersonaAsignada { get; set; }
        public required string Prioridad { get; set; }
        public required string Categoria { get; set; }
        public required string DetallesTarea { get; set; }       
        public DateTime? FechaTarea { get; set; }
        public string Estado { get; set; }  
        public string Comentarios { get; set; }  
    }
}









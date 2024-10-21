namespace TareasAPI.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }
        public int Prioridad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<Etiqueta> Etiquetas { get; set; } = new List<Etiqueta>();
    }
}
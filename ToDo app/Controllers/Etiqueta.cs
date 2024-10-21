namespace TareasAPI.Models
{
    public class Etiqueta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Tarea> Tareas { get; set; } = new List<Tarea>();
    }
}
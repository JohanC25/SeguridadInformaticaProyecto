namespace SeguridadInformaticaProyecto.Models
{
    public class Activo
    {
        public int id { get; set; }
        public string nombre { get; set;}
        public string categoria { get; set;}
        public string subcat { get; set;}
        public string confidencialidad { get; set;}
        public string integridad { get; set;}
        public string disponibilidad { get; set;}
        public int valor { get; set;}   

    }
}

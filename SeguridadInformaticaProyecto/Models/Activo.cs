using System.ComponentModel;

namespace SeguridadInformaticaProyecto.Models
{
    public class Activo
    {
        public int id { get; set; }
        [DisplayName("Nombre Activo")]
        public string nombre { get; set;}
        [DisplayName("Categoria Activo")]
        public string categoria { get; set;}
        [DisplayName("Subcategoria Activo")]
        public string subcat { get; set;}
        [DisplayName("Confidencialidad Activo")]
        public string confidencialidad { get; set;}
        [DisplayName("Integridad Activo")]
        public string integridad { get; set;}
        [DisplayName("Disponibilidad Activo")]
        public string disponibilidad { get; set;}
        [DisplayName("Valor Activo")]
        public int valor { get; set;}   

    }

    public enum Riesgo
    {
        Alto = 1,
        Medio = 2,
        Bajo = 3
    }
}

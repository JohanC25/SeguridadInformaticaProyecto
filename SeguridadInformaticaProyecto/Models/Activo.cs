using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SeguridadInformaticaProyecto.Models
{
    public class Activo
    {
        public int id { get; set; }
        [DisplayName("Nombre Activo")]
        public string nombre { get; set; }
        [DisplayName("Categoria Activo")]
        public string categoria { get; set; }
        [DisplayName("Subcategoria Activo")]
        public string subcat { get; set; }
        [DisplayName("Confidencialidad Activo")]
        public string confidencialidad { get; set; }
        [DisplayName("Integridad Activo")]
        public string integridad { get; set; }
        [DisplayName("Disponibilidad Activo")]
        public string disponibilidad { get; set; }
        [DisplayName("Valor Activo")]
        public int valor { get; set; }

        public static List<string> Categorias { get; set; } = new List<string> { "Software", "Hardware" };

        public Activo()
        {
            categoria = Categorias[0];
        }


    }

    public enum Riesgo
    {
        Alto = 3,
        Medio = 2,
        Bajo = 1
    }
}


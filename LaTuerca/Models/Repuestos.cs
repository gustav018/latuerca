using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaTuerca.Models
{
    public class Repuestos
    {
        public int Id { get; set; }
        public string NombreRepuesto { get; set; }
        public string UnidadDeMedida { get; set; }
        public string Proveedor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Categoria { get; set; }
        public string PrecioCosto { get; set; }
       

    }
}
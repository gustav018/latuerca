using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaTuerca.Models
{
    public class Proveedores
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string DocumentoNumero { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
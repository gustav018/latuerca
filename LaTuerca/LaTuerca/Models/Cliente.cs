using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTuerca.Models
{
    public class Cliente
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar la razon social")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "Debe ingresar el numero de documento")]
        public string Documento { get; set; }
       
        [Required(ErrorMessage = "Debe ingresar el nombre del menú")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre del menú")]
        public string Telefono { get; set; }
    }
}


using System;
using System.ComponentModel.DataAnnotations;

namespace Practica2.Entidades
{
    public class Vehiculos
    {
        //Atributos - Propiedades
        [Required(ErrorMessage = "La Marca es obligatoria")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "El Modelo es obligatorio")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "El Color es obligatorio")]
        public string Color { get; set; }
        [Required(ErrorMessage = "El Precio es obligatorio")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "El Vendedor es obligatorio")]
        public int IdVendedor { get; set; }
    }
}
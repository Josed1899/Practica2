
using System.ComponentModel.DataAnnotations;

namespace Practica2.Entidades
{
    public class Vendedores
    {
        //Atributos - Propiedades

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
    }
}
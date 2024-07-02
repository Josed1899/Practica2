using Practica2.BaseDatos;
using Practica2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Practica2.Models
{
    public class VendedoresModel
    {
        public bool RegistrarVendedores(Entidades.Vendedores entidad)
        {
            using (var context = new Practica2Entities())
            {
                var existeCedula = context.Vendedores.Any(v => v.Cedula == entidad.Cedula);
                if (existeCedula)
                {
                return false; // La cédula ya existe
                }
                var tabla = new BaseDatos.Vendedores();
                tabla.Cedula = entidad.Cedula;
                tabla.Nombre = entidad.Nombre;
                tabla.Correo = entidad.Correo;
                tabla.Estado = true;

            
                    context.Vendedores.Add(tabla);
                    context.SaveChanges();
            }

                return true;
        }
    }
}
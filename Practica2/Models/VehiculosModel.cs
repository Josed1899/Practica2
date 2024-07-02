using Practica2.BaseDatos;
using Practica2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Practica2.Models
{
    
    public class VehiculosModel
    {
        public bool RegistrarVehiculos(Entidades.Vehiculos entidad, out string mensaje)
        {
            using (var context = new Practica2Entities())
            {
                // Contar la cantidad de vehículos de la misma marca
                var cantidadVehiculosMismaMarca = context.Vehiculos
                .Count(v => v.Marca == entidad.Marca);

                if (cantidadVehiculosMismaMarca >= 2)
                {
                    mensaje = "No se pueden registrar más de 2 vehículos de la misma marca.";
                    return false;
                }

                var tabla = new BaseDatos.Vehiculos();
                tabla.Marca = entidad.Marca;
                tabla.Modelo = entidad.Modelo;
                tabla.Color = entidad.Color;
                tabla.Precio = (decimal)entidad.Precio;
                tabla.IdVendedor = entidad.IdVendedor;

            
                context.Vehiculos.Add(tabla);
                context.SaveChanges();
            }

            mensaje = "Vehiculo registrado correctamente";
            return true;
        }
        public List<BaseDatos.Vehiculos> ConsultarVehiculos()
        {
            using (var context = new Practica2Entities())
            {
                return context.Vehiculos
                      .Include(v => v.Vendedores) // Incluye los datos de los vendedores relacionados
                      .ToList();
            }
        }

    }
}
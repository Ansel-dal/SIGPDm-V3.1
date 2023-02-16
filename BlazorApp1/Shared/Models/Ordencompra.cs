using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared.Models
{
    public partial class Ordencompra
    {
        public int Id { get; set; }
        public string? Estado { get; set; }
        public string? Especificacion { get; set; }
        public string? Archivo { get; set; }
        public DateTime? Aprobada { get; set; }
        public DateTime? Generada { get; set; }
        public DateTime? Recepcionada { get; set; }

        [Cantidad]
        public int? Cantidad { get; set; }
        public int? Insumo { get; set; }
        public int? Proveedor { get; set; }

        [Precio]
        public int? Precio { get; set; } //Cambiar de int a float porque el precio puede tener decimales
        public string? CondicionPago { get; set; }
    }

    public class CantidadAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var orden = (Ordencompra)validationContext.ObjectInstance;

            if (orden.Cantidad >= 1)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("La cantidad pedida debe ser mayor o igual a 1");
        }
    }

    public class PrecioAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var orden = (Ordencompra)validationContext.ObjectInstance;

            if (orden.Precio !=null && orden.Precio >= 0)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("El precio debe ser mayor o igual a 0");
        }
    }

}

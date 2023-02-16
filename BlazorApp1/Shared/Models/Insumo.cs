using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared.Models
{
    public class Insumo
    {
        public int Id { get; set; }

        [StockMin]//No es la mejor forma de resolverlo
        public int StockMin { get; set; }

        [StockMax] //No es la mejor forma de resolverlo
        public int StockMax { get; set; }

        [StockReal]
        public int? StockReal { get; set; }
        public string? Nombre { get; set; }
        public string? Codigo { get; set; }
        public string? Foto { get; set; }
        public string? Descripcion { get; set; }
        public string? Recepcion { get; set; }





    }

    public class StockMinAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var insumo = (Insumo)validationContext.ObjectInstance;

            if (insumo.StockMin >= 0)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("El stock mínimo debe ser mayor o igual a cero");
        }
    }

    public class StockMaxAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var insumo = (Insumo)validationContext.ObjectInstance;

            if (insumo.StockMax > insumo.StockMin)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("El stock máximo debe ser mayor al stock mínimo");
        }
    }

    public class StockRealAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var insumo = (Insumo)validationContext.ObjectInstance;

            if (insumo.StockReal >= 0)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("El stock real debe ser mayor o igual a cero");
        }
    }


}

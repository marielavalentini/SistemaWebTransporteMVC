using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebTransporteMVC.Validation
{
    public class CheckYear : ValidationAttribute
    {
        public CheckYear() 
        {
            ErrorMessage = "El año debe ser mayor a 1998";  
        }

        public override bool IsValid(object value)
        {
            int anio = Convert.ToInt32(value);

            if (anio < 1998)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
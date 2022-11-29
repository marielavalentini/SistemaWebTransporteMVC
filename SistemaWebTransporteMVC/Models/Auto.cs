using SistemaWebTransporteMVC.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;

namespace SistemaWebTransporteMVC.Models
{
    public class Auto
    {
        [DisplayName("Id")]
        public int AutoId { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        [CheckYear]
        [DisplayName("Año")]
        public int Anio { get; set; }
        [Required]
        public string Color { get; set; } 
    }
}
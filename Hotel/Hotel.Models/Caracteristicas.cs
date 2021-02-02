using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hotel.Models
{
    public class Caracteristicas
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}

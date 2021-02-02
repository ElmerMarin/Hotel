using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hotel.Models
{
    public class Usuarios
    { 
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Estatus { get; set; }
        public string UsuarioIdPadre { get; set; }
        public string Foto { get; set; }
        public string Puesto { get; set; }
    }
}

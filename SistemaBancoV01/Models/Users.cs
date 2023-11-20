using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancoV01.Models
{
    public class Users 
    {
        public int idusuario { get; set; }
        public int idcliente { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasena { get; set; }
    }
}
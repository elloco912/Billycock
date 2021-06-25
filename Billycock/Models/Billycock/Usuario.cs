﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Billycock.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string descripcion { get; set; }
        public DateTime? fechaInscripcion { get; set; }
        public int? idEstado { get; set; }
        public string facturacion { get; set; }
        public int? pago { get; set; }
        [NotMapped]
        public string descEstado { get; set; }

        public List<UsuarioPlataforma> usuarioPlataformas { get; set; }
    }
}
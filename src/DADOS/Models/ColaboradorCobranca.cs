﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ColaboradorCobranca
    {
        public int IdUsuario { get; set; }
        public bool? InVizualizar { get; set; }
        public bool? InEditar { get; set; }
        public bool? InAtivo { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
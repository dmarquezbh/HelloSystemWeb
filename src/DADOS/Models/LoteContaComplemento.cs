﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LoteContaComplemento
    {
        public int IdLote { get; set; }
        public bool? InMapa { get; set; }
        public bool? InFechado { get; set; }
        public int? IdUsuarioFechou { get; set; }
        public int? IdUsuarioMapa { get; set; }

        public virtual LoteConta IdLoteNavigation { get; set; }
    }
}
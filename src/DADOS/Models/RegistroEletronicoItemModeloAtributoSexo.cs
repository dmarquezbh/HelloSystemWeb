﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RegistroEletronicoItemModeloAtributoSexo
    {
        public int IdRegistroEletronicoItemModeloAtributo { get; set; }
        public int IdSexo { get; set; }
        public bool? InAtivo { get; set; }

        public virtual RegistroEletronicoItemModeloAtributo IdRegistroEletronicoItemModeloAtributoNavigation { get; set; }
        public virtual TipoDiversos IdSexoNavigation { get; set; }
    }
}
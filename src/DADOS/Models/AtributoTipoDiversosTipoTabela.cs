﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AtributoTipoDiversosTipoTabela
    {
        public int IdAtributo { get; set; }
        public int IdTipoTabela { get; set; }
        public bool? InAtivo { get; set; }

        public virtual Atributo IdAtributoNavigation { get; set; }
        public virtual TipoTabela IdTipoTabelaNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TipoTabelaTipoTabela
    {
        public int IdTipoTabelaPai { get; set; }
        public int IdTipoTabelaFilho { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool? InAtivo { get; set; }

        public virtual TipoTabela IdTipoTabelaFilhoNavigation { get; set; }
        public virtual TipoTabela IdTipoTabelaPaiNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProdutoDetalheAtributoLog
    {
        public int IdProdutoDetalheAtributoLog { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public int IdAtributo { get; set; }
        public string VlAtributo { get; set; }
        public DateTime? DtCadastro { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioOperacao { get; set; }

        public virtual Usuario IdUsuarioOperacaoNavigation { get; set; }
    }
}
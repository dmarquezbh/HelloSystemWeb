﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class SolicitacaoProdutoCota
    {
        public int IdSolicitacaoProdutoCota { get; set; }
        public int? IdProdutoDetalhe { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public int? QnProduto { get; set; }
        public DateTime? DtVigencia { get; set; }
        public DateTime? DtCriacao { get; set; }
        public bool? InAtivo { get; set; }
        public int? IdUsuario { get; set; }

        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
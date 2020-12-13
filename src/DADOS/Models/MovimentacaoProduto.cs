﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class MovimentacaoProduto
    {
        public int IdMovimentacaoProduto { get; set; }
        public int IdUnidadeEstoque { get; set; }
        public int? IdUnidadeSolicitante { get; set; }
        public int IdTipoMovimentacao { get; set; }
        public int NrMovimentacao { get; set; }
        public string InEntradaSaida { get; set; }
        public int? IdLoteProdutoItem { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public int? IdFabricante { get; set; }
        public int QnProduto { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public int? IdPrecoMedio { get; set; }
        public bool? InConsignado { get; set; }

        public virtual ProdutoDetalheFabricante Id { get; set; }
        public virtual LoteProdutoItem IdLoteProdutoItemNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeEstoqueNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeSolicitanteNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
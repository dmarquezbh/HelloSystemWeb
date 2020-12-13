﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupo
    {
        public int IdServicoProdutoTabela { get; set; }
        public int IdClassificacao { get; set; }
        public int IdOperadora { get; set; }
        public decimal PrMargem { get; set; }
        public DateTime DtVigenciaMargem { get; set; }
        public decimal PrDesconto { get; set; }
        public DateTime DtVigenciaDesconto { get; set; }
        public bool InPrincipal { get; set; }
        public bool? InAtivo { get; set; }
        public int IdUsuario { get; set; }
        public bool InMenorPreco { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int? IdAtributoPrecoBrasindice { get; set; }
        public int? IdAtributoPrecoBrasindiceRestritoHosp { get; set; }
        public decimal? PrMargemBrasindiceRestritoHosp { get; set; }
        public int? IdTipoCodificacaoItem { get; set; }
        public int? IdTipoTabelaTiss { get; set; }
        public bool InControlaVigenciaProduto { get; set; }

        public virtual Atributo IdAtributoPrecoBrasindiceNavigation { get; set; }
        public virtual Atributo IdAtributoPrecoBrasindiceRestritoHospNavigation { get; set; }
        public virtual ClassificacaoProduto IdClassificacaoNavigation { get; set; }
        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual ServicoProdutoTabela IdServicoProdutoTabelaNavigation { get; set; }
        public virtual TipoDiversos IdTipoCodificacaoItemNavigation { get; set; }
        public virtual TipoDiversos IdTipoTabelaTissNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
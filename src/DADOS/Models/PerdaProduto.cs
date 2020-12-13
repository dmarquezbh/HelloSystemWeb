﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PerdaProduto
    {
        public int IdPerdaProduto { get; set; }
        public DateTime DtPerdaProduto { get; set; }
        public int? IdLoteProdutoItem { get; set; }
        public int? IdProdutoDetalhe { get; set; }
        public int? IdFabricante { get; set; }
        public string NrLote { get; set; }
        public DateTime? DtValidade { get; set; }
        public int IdMotivoPerda { get; set; }
        public string TxObservacao { get; set; }
        public int? IdUnidadeOrganizacionalPerda { get; set; }
        public string NrOcorrencia { get; set; }
        public int? NrNotaFiscal { get; set; }
        public string NmEmpresa { get; set; }
        public DateTime? DtCancelamentoPerda { get; set; }

        public virtual ProdutoDetalheFabricante Id { get; set; }
        public virtual LoteProdutoItem IdLoteProdutoItemNavigation { get; set; }
        public virtual TipoDiversos IdMotivoPerdaNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Tissprocedimentos
    {
        public int? IdLote { get; set; }
        public int IdConta { get; set; }
        public int IdAtendimento { get; set; }
        public int IdGuia { get; set; }
        public int? IdContaItemServico { get; set; }
        public DateTime? DtLancamentoItem { get; set; }
        public double? VlDesconto { get; set; }
        public double VlUnitario { get; set; }
        public decimal? VlCobradoItem { get; set; }
        public double? VlTotalDesconto { get; set; }
        public double? QnServico { get; set; }
        public string CdServicoReferencia { get; set; }
        public string TxDescricaoServicoReferencia { get; set; }
        public DateTime? DtExecucaoServico { get; set; }
        public string CdServico { get; set; }
        public string TxDescricaoServico { get; set; }
        public int? IdServicoProdutoTabela { get; set; }
        public DateTime? HrInicio { get; set; }
        public DateTime? HrFim { get; set; }
        public string ViaAcesso { get; set; }
        public int IdFechamentoItem { get; set; }
        public byte[] RvVersaoLinha { get; set; }
    }
}
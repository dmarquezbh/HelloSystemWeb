﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AdequacaoCodigo
    {
        public int IdFechamentoItem { get; set; }
        public int IdConta { get; set; }
        public int? IdServico { get; set; }
        public int? IdProdutoDetalhe { get; set; }
        public decimal? ValorPago { get; set; }
        public decimal? QuantidadePaga { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? DtAdequacao { get; set; }
        public string Observacao { get; set; }
        public string IdJustificativa { get; set; }

        public virtual FechamentoItem Id { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class GuiaFiscalLog
    {
        public int IdGuiafiscalLog { get; set; }
        public int? IdGuiafiscal { get; set; }
        public string TxIdentificacao { get; set; }
        public decimal? VlGuia { get; set; }
        public bool? InAtivo { get; set; }
        public DateTime? DtCadastro { get; set; }
        public int? IdUsuario { get; set; }
        public string TxObservacoes { get; set; }
        public int? IdImpostoRetido { get; set; }
        public int? IdTipoTributo { get; set; }
        public DateTime? DtVencimento { get; set; }
        public string CdRecolhimento { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioOperacao { get; set; }

        public virtual Usuario IdUsuarioOperacaoNavigation { get; set; }
    }
}
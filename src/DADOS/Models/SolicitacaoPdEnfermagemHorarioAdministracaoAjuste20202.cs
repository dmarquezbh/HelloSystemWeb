﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class SolicitacaoPdEnfermagemHorarioAdministracaoAjuste20202
    {
        public int IdSolicitacaoPdEnfermagemhorarioadministracao { get; set; }
        public int IdSolicitacaoPdEnfermagem { get; set; }
        public int? IdProdutoDetalhe { get; set; }
        public int? IdServico { get; set; }
        public DateTime? HrHorarioAdministracao { get; set; }
        public int IdStatus { get; set; }
        public int? IdJustificativaCancelamento { get; set; }
        public int? IdUsuarioAdministrou { get; set; }
        public DateTime? DtRegistro { get; set; }
        public decimal? QnRequisitada { get; set; }
        public string TxObservacao { get; set; }
        public long? CdCodigoPacote { get; set; }
        public decimal? QnPrescrita { get; set; }
        public int? IdUsuarioDuplaChecagem { get; set; }
        public int? IdProdutoOncologico { get; set; }
    }
}
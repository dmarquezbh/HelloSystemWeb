﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ConfirmacaoDevolucao
    {
        public int IdSolicitacao { get; set; }
        public int? IdProdutoDetalhe { get; set; }
        public DateTime? HrHorarioAdministracao { get; set; }
        public int? IdLoteProdutoItem { get; set; }
        public int IdStatus { get; set; }
        public int IdSolicitacaoPdEnfermagemhorarioadministracaoLoteprodutoitem { get; set; }
        public int IdSolicitacaoPdEnfermagemhorarioadministracao { get; set; }
        public int IdFabricante { get; set; }
        public string CodigoItem { get; set; }
        public string NmPessoa { get; set; }
        public int IdUnidadeSolicitante { get; set; }
    }
}
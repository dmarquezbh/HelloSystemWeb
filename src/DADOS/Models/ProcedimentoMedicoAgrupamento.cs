﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProcedimentoMedicoAgrupamento
    {
        public int IdOperadora { get; set; }
        public int IdServicoProdutoTabela { get; set; }
        public int IdServico { get; set; }
        public int? CdServico { get; set; }
        public string TxDescricao { get; set; }
        public int? NrNivel { get; set; }
        public string NmServicoCategoria { get; set; }
        public int? IdServicoPai { get; set; }
        public string QnFilme { get; set; }
        public string QnIncidencia { get; set; }
        public string VlCustoOperacional { get; set; }
        public string QnAuxiliares { get; set; }
        public string NrPorteAnestesico { get; set; }
        public string VlHonorarios { get; set; }
        public string TxPorteProcedimento { get; set; }
        public string PrIndicePorte { get; set; }
        public string TxUr { get; set; }
        public string InValorMonetario { get; set; }
        public bool InAtivo { get; set; }
        public bool InExcecao { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class MedicamentoNaoPadronizado
    {
        public MedicamentoNaoPadronizado()
        {
            MedicamentoNaoPadronizadoSolicitacaoPdenfermagem = new HashSet<MedicamentoNaoPadronizadoSolicitacaoPdenfermagem>();
        }

        public int IdMedicamentoNaoPadronizado { get; set; }
        public int NrDiasTratamento { get; set; }
        public int IdUnidadeMedidaPrescrita { get; set; }
        public int? IdProdutoDetalhe { get; set; }
        public int IdStatus { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtPedido { get; set; }
        public decimal QnPrescrita { get; set; }
        public string TxJustificativaPedido { get; set; }
        public string TxDescricaoFarmacos { get; set; }
        public string TxNomeComercial { get; set; }
        public string TxFormaFarmaceutica { get; set; }
        public string TxConcentracao { get; set; }
        public string TxMotivoNaoAutorizado { get; set; }

        public virtual TipoDiversos IdStatusNavigation { get; set; }
        public virtual TipoDiversos IdUnidadeMedidaPrescritaNavigation { get; set; }
        public virtual ICollection<MedicamentoNaoPadronizadoSolicitacaoPdenfermagem> MedicamentoNaoPadronizadoSolicitacaoPdenfermagem { get; set; }
    }
}
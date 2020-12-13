﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PedidoDeSangueHemoplusLog
    {
        public int IdPedidoSangueHemoplusLog { get; set; }
        public int IdPedidoSangueHemoplus { get; set; }
        public int IdTipoPedido { get; set; }
        public int IdTipoStatus { get; set; }
        public int IdAtendimento { get; set; }
        public int IdMedicoSolicitante { get; set; }
        public DateTime DtPrevisaoEntrega { get; set; }
        public string TxJustificativa { get; set; }
        public string TxDiagnostico { get; set; }
        public bool InTransfundidoAnteriormente { get; set; }
        public bool InReacoesPrevias { get; set; }
        public string TxAntecedGestacionais { get; set; }
        public decimal VlPeso { get; set; }
        public decimal? VlCoagulacao { get; set; }
        public decimal? QtPlaquetas { get; set; }
        public decimal? VlHematocrito { get; set; }
        public decimal? VlHemoglobina { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public int IdNumeroProntuario { get; set; }
        public int? IdLeito { get; set; }
        public int? IdSolicitacaoHemoplus { get; set; }
        public DateTime? DtPedidoIntegrado { get; set; }
        public string TxJson { get; set; }
        public bool InAtivo { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime? DtAtualizacaoOri { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioOperacao { get; set; }

        public virtual Usuario IdUsuarioOperacaoNavigation { get; set; }
    }
}
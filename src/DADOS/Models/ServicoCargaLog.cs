﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoCargaLog
    {
        public int IdServicoCargaLog { get; set; }
        public int IdServicoCargaHistorico { get; set; }
        public string NrEdicao { get; set; }
        public int IdServicoProdutoTabela { get; set; }
        public int IdServico { get; set; }
        public string CdServico { get; set; }
        public string TxDescricaoServico { get; set; }
        public int IdServicoCategoria { get; set; }
        public string TxPrecoTipo { get; set; }
        public double QnIncidencia { get; set; }
        public double QnFilme { get; set; }
        public double QnAuxiliares { get; set; }
        public double QtdAuxiliaresAnest { get; set; }
        public double NrPorteAnestesico { get; set; }
        public double VlCustoOperacional { get; set; }
        public double VlHonorarios { get; set; }
        public double TxMoeda { get; set; }
        public double ExigeViaAcesso { get; set; }
        public double TxPorteProcedimento { get; set; }
        public double PrIndicePorte { get; set; }
        public double TxUr { get; set; }
        public DateTime DtCarga { get; set; }
        public string TxDescricaoAtualizacao { get; set; }
        public int IdUsuario { get; set; }
        public byte[] RvVersaoLinha { get; set; }
    }
}
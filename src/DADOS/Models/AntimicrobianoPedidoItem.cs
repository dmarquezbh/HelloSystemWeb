﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AntimicrobianoPedidoItem
    {
        public AntimicrobianoPedidoItem()
        {
            AntimicrobianoPedidoItemSolicitacaoPdEnfermagem = new HashSet<AntimicrobianoPedidoItemSolicitacaoPdEnfermagem>();
        }

        public int IdPedidoAntimicrobianoItem { get; set; }
        public int IdPedidoAntimicrobiano { get; set; }
        public int IdStatus { get; set; }
        public int NrDiasTratamento { get; set; }
        public int? NrDosesAutorizadas { get; set; }
        public string QnPrescritaAutorizada { get; set; }
        public decimal? QnPrescritaPrescricao { get; set; }
        public string TxObservacaoCcih { get; set; }
        public int? IdStatusAnterior { get; set; }

        public virtual AntimicrobianoPedido IdPedidoAntimicrobianoNavigation { get; set; }
        public virtual TipoDiversos IdStatusAnteriorNavigation { get; set; }
        public virtual TipoDiversos IdStatusNavigation { get; set; }
        public virtual ICollection<AntimicrobianoPedidoItemSolicitacaoPdEnfermagem> AntimicrobianoPedidoItemSolicitacaoPdEnfermagem { get; set; }
    }
}
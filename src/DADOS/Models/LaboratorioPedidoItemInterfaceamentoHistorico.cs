﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LaboratorioPedidoItemInterfaceamentoHistorico
    {
        public int IdLaboratorioPedidoItemInterfaceamento { get; set; }
        public int IdLaboratorioPedidoItem { get; set; }
        public string TxMensagem { get; set; }
        public string TxArquivo { get; set; }
        public bool InSucesso { get; set; }
        public DateTime DtHistorico { get; set; }
        public string TxCaminhoArquivo { get; set; }

        public virtual LaboratorioPedidoItem IdLaboratorioPedidoItemNavigation { get; set; }
    }
}
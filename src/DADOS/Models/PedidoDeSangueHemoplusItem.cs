﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PedidoDeSangueHemoplusItem
    {
        public int IdPedidoSangueHemoplusItem { get; set; }
        public int IdPedidoSangueHemoplus { get; set; }
        public int IdHemoProcedimento { get; set; }
        public int QdItem { get; set; }
        public bool? InAtivo { get; set; }
        public bool InIntegrado { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtRealizacao { get; set; }
        public string TxDetalhe { get; set; }

        public virtual HemoProcedimento IdHemoProcedimentoNavigation { get; set; }
        public virtual PedidoDeSangueHemoplus IdPedidoSangueHemoplusNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TransferenciaFisicaItem
    {
        public int IdTransferenciaFisicaItem { get; set; }
        public int IdTransferenciaFisica { get; set; }
        public int IdLancamentoBancarioOrigem { get; set; }
        public int IdLancamentoBancarioDestino { get; set; }
        public DateTime DtCadastro { get; set; }
        public int IdUsuario { get; set; }
        public bool? InAtivo { get; set; }
        public bool InCancelado { get; set; }

        public virtual LancamentoBancario IdLancamentoBancarioDestinoNavigation { get; set; }
        public virtual LancamentoBancario IdLancamentoBancarioOrigemNavigation { get; set; }
        public virtual TransferenciaFisica IdTransferenciaFisicaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
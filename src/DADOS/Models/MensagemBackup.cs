﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class MensagemBackup
    {
        public int? IdMensagem { get; set; }
        public int? IdUsuarioRemetente { get; set; }
        public int? IdStatusMensagem { get; set; }
        public int? IdTipoMensagem { get; set; }
        public int? IdMensagemPai { get; set; }
        public string TxAssunto { get; set; }
        public string HtmlMensagem { get; set; }
        public DateTime? DtEnvioMensagem { get; set; }
        public DateTime? DtValidadeMensagem { get; set; }
        public bool? InAceito { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProtocoloAtendimento
    {
        public ProtocoloAtendimento()
        {
            ProtocoloAplicacaoAtendimento = new HashSet<ProtocoloAplicacaoAtendimento>();
        }

        public int IdProtocoloAtendimento { get; set; }
        public int IdProtocolo { get; set; }
        public int IdAtendimento { get; set; }
        public DateTime DtInicioProtocoloUtc { get; set; }
        public int IdUsuario { get; set; }
        public bool? InAtivo { get; set; }
        public bool? InSuspenso { get; set; }
        public string TxPaaCancelados { get; set; }

        public virtual Atendimento IdAtendimentoNavigation { get; set; }
        public virtual Protocolo IdProtocoloNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ProtocoloAplicacaoAtendimento> ProtocoloAplicacaoAtendimento { get; set; }
    }
}
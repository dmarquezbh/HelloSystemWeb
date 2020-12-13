﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Protocolo
    {
        public Protocolo()
        {
            ProtocoloAtendimento = new HashSet<ProtocoloAtendimento>();
            ProtocoloItem = new HashSet<ProtocoloItem>();
            ProtocoloServico = new HashSet<ProtocoloServico>();
        }

        public int IdProtocolo { get; set; }
        public string NmProtocolo { get; set; }
        public string TxReferenciaBibliografica { get; set; }
        public bool? InAtivo { get; set; }
        public int IdUsuario { get; set; }
        public bool? InAjusteHorarioPrimeiraImportacao { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ProtocoloAtendimento> ProtocoloAtendimento { get; set; }
        public virtual ICollection<ProtocoloItem> ProtocoloItem { get; set; }
        public virtual ICollection<ProtocoloServico> ProtocoloServico { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AtendimentoUsuario
    {
        public int IdAtendimentoUsuario { get; set; }
        public int IdAtendimento { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string TxAlteracao { get; set; }

        public virtual Atendimento IdAtendimentoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
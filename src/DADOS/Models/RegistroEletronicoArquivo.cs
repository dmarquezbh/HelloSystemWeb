﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RegistroEletronicoArquivo
    {
        public int IdRegistroEletronicoArquivo { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdAtendimento { get; set; }
        public string TxDescricao { get; set; }
        public DateTime DtArquivo { get; set; }
        public byte[] AdArquivo { get; set; }
        public string NmArquivo { get; set; }
        public bool? InAtivo { get; set; }

        public virtual Atendimento IdAtendimentoNavigation { get; set; }
        public virtual Pessoa IdPessoaNavigation { get; set; }
    }
}
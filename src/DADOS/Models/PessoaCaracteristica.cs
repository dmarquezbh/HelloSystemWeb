﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PessoaCaracteristica
    {
        public int IdPessoa { get; set; }
        public int IdPessoaEntidade { get; set; }
        public int IdAtributo { get; set; }
        public string TxValorAtributo { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual PessoaEntidadePessoaAtributo Id { get; set; }
        public virtual Pessoa IdPessoaNavigation { get; set; }
    }
}
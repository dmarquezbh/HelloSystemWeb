﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OperadoraEmpresaConveniada
    {
        public int IdPessoa { get; set; }
        public int IdOperadora { get; set; }
        public bool InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool InAtivada { get; set; }

        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual Pessoa IdPessoaNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class UnidadeOrganizacionalPessoaEntidade
    {
        public int IdUnidadeOrganizacional { get; set; }
        public int IdPessoaEntidade { get; set; }
        public int? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual PessoaEntidade IdPessoaEntidadeNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
    }
}
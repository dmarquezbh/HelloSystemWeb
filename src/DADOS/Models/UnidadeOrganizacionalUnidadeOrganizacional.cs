﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class UnidadeOrganizacionalUnidadeOrganizacional
    {
        public int IdUnidadeOrganizacionalDependente { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int IdClassificacao { get; set; }

        public virtual TipoDiversos IdClassificacaoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalDependenteNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
    }
}
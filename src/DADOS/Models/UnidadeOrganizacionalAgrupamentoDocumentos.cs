﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class UnidadeOrganizacionalAgrupamentoDocumentos
    {
        public int IdUnidadeOrganizacionalPai { get; set; }
        public int IdUnidadeOrganizacionalFilho { get; set; }
        public bool? InAtivo { get; set; }

        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalFilhoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalPaiNavigation { get; set; }
    }
}
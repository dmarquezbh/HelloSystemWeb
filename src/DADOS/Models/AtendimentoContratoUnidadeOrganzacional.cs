﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AtendimentoContratoUnidadeOrganzacional
    {
        public int IdAtendimentoContrato { get; set; }
        public int IdUnidadeOrganizacional { get; set; }

        public virtual AtendimentoContrato IdAtendimentoContratoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
    }
}
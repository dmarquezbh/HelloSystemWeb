﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ContaOrdemUnidadeOrganizacional
    {
        public int IdUnidadeOrganizacionalParametro { get; set; }
        public int NrOrdem { get; set; }

        public virtual TipoDiversos IdUnidadeOrganizacionalParametroNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class UnidadeOrganizacionalServicoAutomatico
    {
        public int IdUnidadeOrganizacional { get; set; }
        public int IdServico { get; set; }

        public virtual Servico IdServicoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class UnidadeOrganizacionalServico
    {
        public UnidadeOrganizacionalServico()
        {
            RepasseOperadoraUnidadeOrganizacionalServico = new HashSet<RepasseOperadoraUnidadeOrganizacionalServico>();
        }

        public int IdServico { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public bool InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual Servico IdServicoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual ICollection<RepasseOperadoraUnidadeOrganizacionalServico> RepasseOperadoraUnidadeOrganizacionalServico { get; set; }
    }
}
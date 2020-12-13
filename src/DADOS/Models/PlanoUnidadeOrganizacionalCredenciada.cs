﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PlanoUnidadeOrganizacionalCredenciada
    {
        public PlanoUnidadeOrganizacionalCredenciada()
        {
            PlanoUnidadeOrganizacionalHistorico = new HashSet<PlanoUnidadeOrganizacionalHistorico>();
            PlanoUnidadeOrganizacionalHistoricoCh = new HashSet<PlanoUnidadeOrganizacionalHistoricoCh>();
        }

        public int IdPlano { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public int IdStatus { get; set; }
        public double? VlCh { get; set; }
        public double? VlChExterno { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public string TxInstrucaoAtendimento { get; set; }
        public double? VlTaxaAcrescimoServico { get; set; }
        public double? VlTaxaAcrescimoHonorario { get; set; }
        public bool? InEnvioAutomaticoContaLote { get; set; }

        public virtual Plano IdPlanoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual ICollection<PlanoUnidadeOrganizacionalHistorico> PlanoUnidadeOrganizacionalHistorico { get; set; }
        public virtual ICollection<PlanoUnidadeOrganizacionalHistoricoCh> PlanoUnidadeOrganizacionalHistoricoCh { get; set; }
    }
}
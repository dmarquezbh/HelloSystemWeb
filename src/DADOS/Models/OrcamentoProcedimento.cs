﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrcamentoProcedimento
    {
        public OrcamentoProcedimento()
        {
            OrcamentoProcedimentoServico = new HashSet<OrcamentoProcedimentoServico>();
        }

        public int IdOrcamento { get; set; }
        public string NmPaciente { get; set; }
        public DateTime DtOrcamento { get; set; }
        public int? IdUsuarioCriador { get; set; }
        public int? IdPlano { get; set; }
        public int InAtivo { get; set; }

        public virtual Plano IdPlanoNavigation { get; set; }
        public virtual Usuario IdUsuarioCriadorNavigation { get; set; }
        public virtual ICollection<OrcamentoProcedimentoServico> OrcamentoProcedimentoServico { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrdemServicoExameItemExame
    {
        public OrdemServicoExameItemExame()
        {
            OrdemServicoExameItemExameHistorico = new HashSet<OrdemServicoExameItemExameHistorico>();
        }

        public int IdOrdemServico { get; set; }
        public int IdMaterialTipo { get; set; }
        public int IdExame { get; set; }
        public int IdItemExame { get; set; }
        public string TxValorResultado { get; set; }
        public DateTime DtResultado { get; set; }
        public int IdUsuarioDigitacao { get; set; }
        public int? IdUsuarioAprovacao { get; set; }

        public virtual OrdemServicoExame Id { get; set; }
        public virtual ItemExame IdItemExameNavigation { get; set; }
        public virtual Usuario IdUsuarioAprovacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioDigitacaoNavigation { get; set; }
        public virtual ICollection<OrdemServicoExameItemExameHistorico> OrdemServicoExameItemExameHistorico { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrcamentoProcedimentoServico
    {
        public int IdOrcamento { get; set; }
        public int IdServico { get; set; }
        public double? VlServico { get; set; }
        public int? NrQuantidade { get; set; }
        public int InAtivo { get; set; }

        public virtual OrcamentoProcedimento IdOrcamentoNavigation { get; set; }
        public virtual Servico IdServicoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrcamentoValoresOutrosItens
    {
        public int IdOrcamentoValoresOutros { get; set; }
        public int IdOrcamentoOrcamento { get; set; }
        public string DescricaoOutros { get; set; }
        public int? QnOutros { get; set; }
        public decimal? VlItem { get; set; }

        public virtual OrcamentoOrcamento IdOrcamentoOrcamentoNavigation { get; set; }
    }
}
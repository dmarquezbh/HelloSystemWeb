﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OperadoraPlanoTesteDba
    {
        public int IdOperadora { get; set; }
        public string NmOperadora { get; set; }
        public int? IdPlano { get; set; }
        public string NmPlano { get; set; }
        public int IdServicoProdutoTabela { get; set; }
        public int IdServicoProdutoTabelaTipo { get; set; }
        public int InFaturamentoPlano { get; set; }
        public DateTime? DtInicioVigencia { get; set; }
    }
}
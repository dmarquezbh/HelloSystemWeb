﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrdemcompraHistorico
    {
        public int IdOrdemcompraHistorico { get; set; }
        public int? IdOrdemCompra { get; set; }
        public int? IdFornecedor { get; set; }
        public int? IdCondicaoPagamento { get; set; }
        public DateTime? DtEdicao { get; set; }
        public int? IdUsuarioEditou { get; set; }
    }
}
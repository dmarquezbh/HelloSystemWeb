﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrdemCompraAdiantamento
    {
        public OrdemCompraAdiantamento()
        {
            ContaPagar = new HashSet<ContaPagar>();
        }

        public int IdOrdemCompraAdiantamento { get; set; }
        public int IdOrdemCompra { get; set; }
        public decimal VlAdiantamento { get; set; }
        public DateTime DtInclusao { get; set; }
        public int IdUsuario { get; set; }
        public bool? InAtivo { get; set; }

        public virtual OrdemCompra IdOrdemCompraNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ContaPagar> ContaPagar { get; set; }
    }
}
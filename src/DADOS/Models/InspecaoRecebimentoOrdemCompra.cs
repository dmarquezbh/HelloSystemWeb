﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class InspecaoRecebimentoOrdemCompra
    {
        public int IdInspecaoRecebimento { get; set; }
        public int IdOrdemCompra { get; set; }

        public virtual InspecaoRecebimento IdInspecaoRecebimentoNavigation { get; set; }
        public virtual OrdemCompra IdOrdemCompraNavigation { get; set; }
    }
}
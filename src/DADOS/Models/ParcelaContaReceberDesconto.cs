﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ParcelaContaReceberDesconto
    {
        public int IdContaReceber { get; set; }
        public int NrParcela { get; set; }
        public int IdTipoDesconto { get; set; }
        public decimal VlDesconto { get; set; }

        public virtual TipoDiversos IdTipoDescontoNavigation { get; set; }
        public virtual ParcelaContaReceber ParcelaContaReceber { get; set; }
    }
}
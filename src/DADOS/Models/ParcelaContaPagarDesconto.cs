﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ParcelaContaPagarDesconto
    {
        public int IdContaPagar { get; set; }
        public int NrParcela { get; set; }
        public int IdTipoDesconto { get; set; }
        public double VlDesconto { get; set; }

        public virtual TipoDiversos IdTipoDescontoNavigation { get; set; }
        public virtual ParcelaContaPagar ParcelaContaPagar { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ParcelaCondicaoPagamento
    {
        public int IdCondicaoPagamento { get; set; }
        public int NrParcela { get; set; }
        public int NrDias { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual CondicaoPagamento IdCondicaoPagamentoNavigation { get; set; }
    }
}
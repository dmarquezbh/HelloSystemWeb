﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CondicaoPagamentoBionexo
    {
        public int IdCondicaoPagamentoBionexo { get; set; }
        public string NmCondicaoPagamentoBionexo { get; set; }
        public int IdFormaPagamentoBionexo { get; set; }
        public int IdEntidadeSistemaLegado { get; set; }

        public virtual TipoDiversos IdEntidadeSistemaLegadoNavigation { get; set; }
    }
}
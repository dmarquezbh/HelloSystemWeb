﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ParcelaContaReceberBaixaAcrescimo
    {
        public int IdParcelacontareceberBaixaAcrescimo { get; set; }
        public int IdParcelacontareceberBaixa { get; set; }
        public int IdTipoAcrescimo { get; set; }
        public decimal VlAcrescimo { get; set; }
        public decimal? PrAcrescimo { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool? InAtivo { get; set; }

        public virtual ParcelaContaReceberBaixa IdParcelacontareceberBaixaNavigation { get; set; }
        public virtual TipoDiversos IdTipoAcrescimoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
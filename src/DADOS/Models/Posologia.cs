﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Posologia
    {
        public int IdPosologia { get; set; }
        public int NrDosagem { get; set; }
        public int IdUnidadeMedidaDosagem { get; set; }
        public double? NrPeso { get; set; }
        public int? IdUnidadeMedidaPeso { get; set; }
        public int IdTempoAdministracao { get; set; }
        public int? IdFaixaEtaria { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual FaixaEtaria IdFaixaEtariaNavigation { get; set; }
        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
        public virtual IntervaloAplicacaoMedicamento IdTempoAdministracaoNavigation { get; set; }
        public virtual TipoDiversos IdUnidadeMedidaDosagemNavigation { get; set; }
        public virtual TipoDiversos IdUnidadeMedidaPesoNavigation { get; set; }
    }
}
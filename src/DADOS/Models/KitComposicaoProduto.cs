﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class KitComposicaoProduto
    {
        public int IdKit { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public int IdUnidadeMedida { get; set; }
        public decimal QnProduto { get; set; }
        public bool InOpcional { get; set; }
        public bool? InOpcionalPrescricao { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool? InImpressoPrescricao { get; set; }

        public virtual Kit IdKitNavigation { get; set; }
        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
        public virtual TipoDiversos IdUnidadeMedidaNavigation { get; set; }
    }
}
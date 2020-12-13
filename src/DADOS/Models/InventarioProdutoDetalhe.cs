﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class InventarioProdutoDetalhe
    {
        public InventarioProdutoDetalhe()
        {
            InventarioProdutoDetalheLoteProdutoItem = new HashSet<InventarioProdutoDetalheLoteProdutoItem>();
        }

        public int IdInventario { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public int IdFabricante { get; set; }
        public DateTime? DtCorte { get; set; }
        public int? QnEstoqueAtual { get; set; }
        public DateTime? DtContagem { get; set; }
        public int? QnPrimeiraContagem { get; set; }
        public int? QnSegundaContagem { get; set; }
        public int? QnTerceiraContagem { get; set; }
        public int? IdUnidadeMedida { get; set; }
        public int? IdStatusContagem { get; set; }
        public bool? InUltimaContagem { get; set; }

        public virtual Inventario IdInventarioNavigation { get; set; }
        public virtual StatusInventarioProdutoDetalhe IdStatusContagemNavigation { get; set; }
        public virtual TipoDiversos IdUnidadeMedidaNavigation { get; set; }
        public virtual ICollection<InventarioProdutoDetalheLoteProdutoItem> InventarioProdutoDetalheLoteProdutoItem { get; set; }
    }
}
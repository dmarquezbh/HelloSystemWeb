﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Inventario
    {
        public Inventario()
        {
            InventarioAtualizacao = new HashSet<InventarioAtualizacao>();
            InventarioProdutoDetalhe = new HashSet<InventarioProdutoDetalhe>();
        }

        public int IdInventario { get; set; }
        public DateTime DtInventario { get; set; }
        public int IdTipoInventario { get; set; }
        public int IdResponsavelAutorizacao { get; set; }
        public int IdCoordenador { get; set; }
        public int IdStatusInventario { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public DateTime? DtAtualizacaoInventario { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public bool? InRastreabilidade { get; set; }
        public bool? InConsignado { get; set; }
        public bool? InBloquearMovimentacao { get; set; }

        public virtual Usuario IdCoordenadorNavigation { get; set; }
        public virtual Usuario IdResponsavelAutorizacaoNavigation { get; set; }
        public virtual StatusInventario IdStatusInventarioNavigation { get; set; }
        public virtual TipoInventario IdTipoInventarioNavigation { get; set; }
        public virtual ICollection<InventarioAtualizacao> InventarioAtualizacao { get; set; }
        public virtual ICollection<InventarioProdutoDetalhe> InventarioProdutoDetalhe { get; set; }
    }
}
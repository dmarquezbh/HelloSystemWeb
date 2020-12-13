﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProdutoNaoCoberto
    {
        public int IdProdutoNaoCoberto { get; set; }
        public int? IdOperadora { get; set; }
        public int? IdPlano { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public int? IdServico { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public int? IdFabricante { get; set; }
        public DateTime DtInicio { get; set; }
        public int IdUsuarioDtInicio { get; set; }
        public DateTime? DtFinal { get; set; }
        public int? IdUsuarioDtFinal { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public DateTime DtCadastro { get; set; }

        public virtual ProdutoDetalheFabricante Id { get; set; }
        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual Plano IdPlanoNavigation { get; set; }
        public virtual Servico IdServicoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual Usuario IdUsuarioDtFinalNavigation { get; set; }
        public virtual Usuario IdUsuarioDtInicioNavigation { get; set; }
    }
}
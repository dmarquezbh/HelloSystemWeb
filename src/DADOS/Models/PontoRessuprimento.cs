﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PontoRessuprimento
    {
        public int IdProdutoDetalhe { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public DateTime DtVigencia { get; set; }
        public int? QnEstoqueMaximo { get; set; }
        public int? QnEstoqueMinimo { get; set; }
        public int? QnPontoRessuprimento { get; set; }
        public int? QnPontoCritico { get; set; }
        public int? IdUnidadeMedida { get; set; }
        public bool? InAtivo { get; set; }

        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
        public virtual TipoDiversos IdUnidadeMedidaNavigation { get; set; }
    }
}
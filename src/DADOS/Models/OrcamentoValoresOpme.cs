﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrcamentoValoresOpme
    {
        /// <summary>
        /// Identificador único 
        /// </summary>
        public int IdOrcamentoValoresOpme { get; set; }
        /// <summary>
        /// Identificador único. Foreign key tabela OrcamentoOrcamento.
        /// </summary>
        public int? IdOrcamentoOrcamento { get; set; }
        /// <summary>
        /// Identificador único (FK) para a tabela ProdutoDetalhe.
        /// </summary>
        public int IdProdutoDetalhe { get; set; }
        /// <summary>
        /// Identificador único do fornecedor. 
        /// </summary>
        public int? IdFornecedor { get; set; }
        /// <summary>
        /// Quantidade do item OPME.
        /// </summary>
        public int? QnOpme { get; set; }
        /// <summary>
        /// Valor unitário do OPME.
        /// </summary>
        public double? VlUnitarioOpme { get; set; }

        public virtual Pessoa IdFornecedorNavigation { get; set; }
        public virtual OrcamentoOrcamento IdOrcamentoOrcamentoNavigation { get; set; }
        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
    }
}
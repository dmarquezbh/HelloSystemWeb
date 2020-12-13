﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ExameItemMaterial
    {
        public ExameItemMaterial()
        {
            LaboratorioPedidoResultadoItem = new HashSet<LaboratorioPedidoResultadoItem>();
        }

        /// <summary>
        /// identificador da relação entre exame_material e seus itens de resultado
        /// </summary>
        public int IdExameItemMaterial { get; set; }
        /// <summary>
        /// identificador do exame junto ao material e método
        /// </summary>
        public int IdExameMaterial { get; set; }
        /// <summary>
        /// ordem que os campos aparecem na tela e que são impressos
        /// </summary>
        public int NrOrdem { get; set; }
        /// <summary>
        /// label do item que aparece no resultado
        /// </summary>
        public string NmItem { get; set; }
        /// <summary>
        /// valor de referência
        /// </summary>
        public string TxReferencia { get; set; }
        /// <summary>
        /// tipo do dado que será lançado
        /// </summary>
        public int IdTipoValor { get; set; }
        /// <summary>
        /// se o dado é obrigatório
        /// </summary>
        public bool InObrigatorio { get; set; }
        /// <summary>
        /// grupo de validação de dados, se existir um % dentro de um grupo, este deve totalizar 100%
        /// </summary>
        public string TxGrupo { get; set; }
        /// <summary>
        /// tamanho dos campos, caso texto
        /// </summary>
        public int? NrTamanho { get; set; }
        /// <summary>
        /// unidade de medida, tipo tabela 137
        /// </summary>
        public int? IdUnidade { get; set; }
        /// <summary>
        /// range mínimo para alertar o laboratório
        /// </summary>
        public double? NrRangeMin { get; set; }
        /// <summary>
        /// range máximo para alertar o laboratório
        /// </summary>
        public double? NrRangeMax { get; set; }
        /// <summary>
        /// quando o item tem valores predefinidos e utilizam a estrutura do tipodiversos, como cor de urina
        /// </summary>
        public int? IdTabela { get; set; }
        /// <summary>
        /// excelusão lógica
        /// </summary>
        public bool? InAtivo { get; set; }
        /// <summary>
        /// quando o item é calculado
        /// </summary>
        public string TxFormula { get; set; }
        /// <summary>
        /// quando o item é % pode ter um valor absoluto referente a um campo ou fórmula
        /// </summary>
        public string TxCampoReferencia { get; set; }
        public string TxCodInterfaceamento { get; set; }
        public double? NrRangevermelhoMin { get; set; }
        public double? NrRangevermelhoMax { get; set; }
        /// <summary>
        /// range de segurança para alertar o laboratório (campos texto e tabela)
        /// </summary>
        public string TxRangeAmarelo { get; set; }
        /// <summary>
        /// range crítico para alertar o laboratório (campos texto e tabela)
        /// </summary>
        public string TxRangeVermelho { get; set; }
        public bool? InExibeLaudo { get; set; }
        public int? NrOrdemExp { get; set; }

        public virtual TipoTabela IdTabelaNavigation { get; set; }
        public virtual TipoDiversos IdTipoValorNavigation { get; set; }
        public virtual TipoDiversos IdUnidadeNavigation { get; set; }
        public virtual ICollection<LaboratorioPedidoResultadoItem> LaboratorioPedidoResultadoItem { get; set; }
    }
}
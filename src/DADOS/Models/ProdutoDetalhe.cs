﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProdutoDetalhe
    {
        public ProdutoDetalhe()
        {
            AgrupamentoMaterialProduto = new HashSet<AgrupamentoMaterialProduto>();
            ComplementoDietetico = new HashSet<ComplementoDietetico>();
            ConcentracaoPrincipioAtivo = new HashSet<ConcentracaoPrincipioAtivo>();
            CotacaoProduto = new HashSet<CotacaoProduto>();
            DietaPadronizadaMedicamento = new HashSet<DietaPadronizadaMedicamento>();
            EstoqueFechamentoMensal = new HashSet<EstoqueFechamentoMensal>();
            EstoqueFechamentoMensalConsignado = new HashSet<EstoqueFechamentoMensalConsignado>();
            FaltaLancamento = new HashSet<FaltaLancamento>();
            Kit = new HashSet<Kit>();
            KitComposicaoProduto = new HashSet<KitComposicaoProduto>();
            KitTaxasGases = new HashSet<KitTaxasGases>();
            OrcamentoValoresOpme = new HashSet<OrcamentoValoresOpme>();
            PontoRessuprimento = new HashSet<PontoRessuprimento>();
            Posologia = new HashSet<Posologia>();
            ProdutoDetalheAtributo = new HashSet<ProdutoDetalheAtributo>();
            ProdutoDetalheBarreiraHorario = new HashSet<ProdutoDetalheBarreiraHorario>();
            ProdutoDetalheFabricante = new HashSet<ProdutoDetalheFabricante>();
            ProdutoDetalheFabricanteCodigoBarras = new HashSet<ProdutoDetalheFabricanteCodigoBarras>();
            ProdutoDetalheHistorio = new HashSet<ProdutoDetalheHistorio>();
            ProdutoDetalheInstrucaoEspecial = new HashSet<ProdutoDetalheInstrucaoEspecial>();
            ProdutoDetalheViaAdministracao = new HashSet<ProdutoDetalheViaAdministracao>();
            ProdutoLocalizacao = new HashSet<ProdutoLocalizacao>();
            ProdutoUnidadeMedidaConversao = new HashSet<ProdutoUnidadeMedidaConversao>();
            ProdutoUnidadeMedidaConversaoHistorico = new HashSet<ProdutoUnidadeMedidaConversaoHistorico>();
            ProtocoloAplicacaoAtendimento = new HashSet<ProtocoloAplicacaoAtendimento>();
            ProtocoloItem = new HashSet<ProtocoloItem>();
            ProtocoloOncologicoItem = new HashSet<ProtocoloOncologicoItem>();
            RestricaoProdutoDetalhe = new HashSet<RestricaoProdutoDetalhe>();
            SessaoOncologiaItem = new HashSet<SessaoOncologiaItem>();
            SolicitacaoHistorico = new HashSet<SolicitacaoHistorico>();
            SolicitacaoPdEnfermagemHorarioAdministracao = new HashSet<SolicitacaoPdEnfermagemHorarioAdministracao>();
            SolicitacaoProdutoCota = new HashSet<SolicitacaoProdutoCota>();
            SolicitacaoProdutoDetalhe = new HashSet<SolicitacaoProdutoDetalhe>();
            TextoPadraoProdutoDetalhe = new HashSet<TextoPadraoProdutoDetalhe>();
        }

        /// <summary>
        /// Identificador unico da Tabela. Representa um produto detalhe.
        /// 
        /// </summary>
        public int IdProdutoDetalhe { get; set; }
        /// <summary>
        /// FK com Produto.
        /// </summary>
        public int IdProduto { get; set; }
        /// <summary>
        /// Texto com complemento do Produto em realação ao Produto Detalhe.
        /// 
        /// </summary>
        public string TxComplemento { get; set; }
        /// <summary>
        /// Controle que informa se o produto detalhe compoe um KIT de MAT/MED.
        /// </summary>
        public bool? InBaseKit { get; set; }
        /// <summary>
        /// Controle para dizer se o produto é ou não padrão ou seja, se faz parte de um conjunto de produtos que o Hospital sempre tem.
        /// 
        /// </summary>
        public bool InPadronizado { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        /// <summary>
        /// Quantida minima de consumo do Produto.
        /// </summary>
        public int? QnConsumoMinimo { get; set; }
        /// <summary>
        /// Unidade de Medida de consumo do Produto Detalhe. FK com TipoDiversos.
        /// 
        /// </summary>
        public int? IdMdConsumoMinimo { get; set; }
        /// <summary>
        /// Unidade de Medida de compra do Produto Detalhe. FK com TipoDiversos.
        /// 
        /// </summary>
        public int? IdMdCompra { get; set; }
        public string TxObservacao { get; set; }
        public byte[] ArImagem { get; set; }
        public bool? InPendenteCadastro { get; set; }

        public virtual TipoDiversos IdMdCompraNavigation { get; set; }
        public virtual TipoDiversos IdMdConsumoMinimoNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual HospitaleBionexoTraducao HospitaleBionexoTraducao { get; set; }
        public virtual ICollection<AgrupamentoMaterialProduto> AgrupamentoMaterialProduto { get; set; }
        public virtual ICollection<ComplementoDietetico> ComplementoDietetico { get; set; }
        public virtual ICollection<ConcentracaoPrincipioAtivo> ConcentracaoPrincipioAtivo { get; set; }
        public virtual ICollection<CotacaoProduto> CotacaoProduto { get; set; }
        public virtual ICollection<DietaPadronizadaMedicamento> DietaPadronizadaMedicamento { get; set; }
        public virtual ICollection<EstoqueFechamentoMensal> EstoqueFechamentoMensal { get; set; }
        public virtual ICollection<EstoqueFechamentoMensalConsignado> EstoqueFechamentoMensalConsignado { get; set; }
        public virtual ICollection<FaltaLancamento> FaltaLancamento { get; set; }
        public virtual ICollection<Kit> Kit { get; set; }
        public virtual ICollection<KitComposicaoProduto> KitComposicaoProduto { get; set; }
        public virtual ICollection<KitTaxasGases> KitTaxasGases { get; set; }
        public virtual ICollection<OrcamentoValoresOpme> OrcamentoValoresOpme { get; set; }
        public virtual ICollection<PontoRessuprimento> PontoRessuprimento { get; set; }
        public virtual ICollection<Posologia> Posologia { get; set; }
        public virtual ICollection<ProdutoDetalheAtributo> ProdutoDetalheAtributo { get; set; }
        public virtual ICollection<ProdutoDetalheBarreiraHorario> ProdutoDetalheBarreiraHorario { get; set; }
        public virtual ICollection<ProdutoDetalheFabricante> ProdutoDetalheFabricante { get; set; }
        public virtual ICollection<ProdutoDetalheFabricanteCodigoBarras> ProdutoDetalheFabricanteCodigoBarras { get; set; }
        public virtual ICollection<ProdutoDetalheHistorio> ProdutoDetalheHistorio { get; set; }
        public virtual ICollection<ProdutoDetalheInstrucaoEspecial> ProdutoDetalheInstrucaoEspecial { get; set; }
        public virtual ICollection<ProdutoDetalheViaAdministracao> ProdutoDetalheViaAdministracao { get; set; }
        public virtual ICollection<ProdutoLocalizacao> ProdutoLocalizacao { get; set; }
        public virtual ICollection<ProdutoUnidadeMedidaConversao> ProdutoUnidadeMedidaConversao { get; set; }
        public virtual ICollection<ProdutoUnidadeMedidaConversaoHistorico> ProdutoUnidadeMedidaConversaoHistorico { get; set; }
        public virtual ICollection<ProtocoloAplicacaoAtendimento> ProtocoloAplicacaoAtendimento { get; set; }
        public virtual ICollection<ProtocoloItem> ProtocoloItem { get; set; }
        public virtual ICollection<ProtocoloOncologicoItem> ProtocoloOncologicoItem { get; set; }
        public virtual ICollection<RestricaoProdutoDetalhe> RestricaoProdutoDetalhe { get; set; }
        public virtual ICollection<SessaoOncologiaItem> SessaoOncologiaItem { get; set; }
        public virtual ICollection<SolicitacaoHistorico> SolicitacaoHistorico { get; set; }
        public virtual ICollection<SolicitacaoPdEnfermagemHorarioAdministracao> SolicitacaoPdEnfermagemHorarioAdministracao { get; set; }
        public virtual ICollection<SolicitacaoProdutoCota> SolicitacaoProdutoCota { get; set; }
        public virtual ICollection<SolicitacaoProdutoDetalhe> SolicitacaoProdutoDetalhe { get; set; }
        public virtual ICollection<TextoPadraoProdutoDetalhe> TextoPadraoProdutoDetalhe { get; set; }
    }
}
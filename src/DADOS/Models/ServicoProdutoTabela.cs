﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoProdutoTabela
    {
        public ServicoProdutoTabela()
        {
            Plano = new HashSet<Plano>();
            ProdutoUnidadeMedidaConversao = new HashSet<ProdutoUnidadeMedidaConversao>();
            ProdutoUnidadeMedidaConversaoHistorico = new HashSet<ProdutoUnidadeMedidaConversaoHistorico>();
            ServicoPreco = new HashSet<ServicoPreco>();
            ServicoProdutoTabelaOperadora = new HashSet<ServicoProdutoTabelaOperadora>();
            ServicoProdutoTabelaOperadoraClassificacaoProduto = new HashSet<ServicoProdutoTabelaOperadoraClassificacaoProduto>();
            ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativa = new HashSet<ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativa>();
            ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativaHistorico = new HashSet<ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativaHistorico>();
            ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupo = new HashSet<ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupo>();
            ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupoHistorico = new HashSet<ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupoHistorico>();
            ServicoProdutoTabelaOperadoraHistorico = new HashSet<ServicoProdutoTabelaOperadoraHistorico>();
            ServicoProdutoTabelaPlano = new HashSet<ServicoProdutoTabelaPlano>();
            ServicoProdutoTabelaPlanoClassificacaoProduto = new HashSet<ServicoProdutoTabelaPlanoClassificacaoProduto>();
            ServicoProdutoTabelaPlanoClassificacaoProdutoAlternativa = new HashSet<ServicoProdutoTabelaPlanoClassificacaoProdutoAlternativa>();
            ServicoProdutoTabelaPlanoClassificacaoProdutoAlternativaHistorico = new HashSet<ServicoProdutoTabelaPlanoClassificacaoProdutoAlternativaHistorico>();
            ServicoProdutoTabelaPlanoClassificacaoProdutoGrupo = new HashSet<ServicoProdutoTabelaPlanoClassificacaoProdutoGrupo>();
            ServicoProdutoTabelaPlanoClassificacaoProdutoGrupoHistorico = new HashSet<ServicoProdutoTabelaPlanoClassificacaoProdutoGrupoHistorico>();
            ServicoProdutoTabelaPlanoHistorico = new HashSet<ServicoProdutoTabelaPlanoHistorico>();
            ServicoProdutoTabelaPorteTabela = new HashSet<ServicoProdutoTabelaPorteTabela>();
            ServicoServicoProdutoTabela = new HashSet<ServicoServicoProdutoTabela>();
            ServicoTraducaoVigencia = new HashSet<ServicoTraducaoVigencia>();
        }

        public int IdServicoProdutoTabela { get; set; }
        public string NmServicoProdutoTabela { get; set; }
        public int IdServicoProdutoTabelaTipo { get; set; }
        public int? IdServicoProdutoTabelaTipoEstrutura { get; set; }
        public int IdEmissorTabela { get; set; }
        public bool InReal { get; set; }
        public bool InFracionado { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime? DtImportacao { get; set; }
        public DateTime? DtCopia { get; set; }
        public int IdUsuario { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int? IdTipoTabelaProduto { get; set; }

        public virtual Pessoa IdEmissorTabelaNavigation { get; set; }
        public virtual TipoDiversos IdServicoProdutoTabelaTipoNavigation { get; set; }
        public virtual TipoDiversos IdTipoTabelaProdutoNavigation { get; set; }
        public virtual ICollection<Plano> Plano { get; set; }
        public virtual ICollection<ProdutoUnidadeMedidaConversao> ProdutoUnidadeMedidaConversao { get; set; }
        public virtual ICollection<ProdutoUnidadeMedidaConversaoHistorico> ProdutoUnidadeMedidaConversaoHistorico { get; set; }
        public virtual ICollection<ServicoPreco> ServicoPreco { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadora> ServicoProdutoTabelaOperadora { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraClassificacaoProduto> ServicoProdutoTabelaOperadoraClassificacaoProduto { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativa> ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativa { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativaHistorico> ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativaHistorico { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupo> ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupo { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupoHistorico> ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupoHistorico { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraHistorico> ServicoProdutoTabelaOperadoraHistorico { get; set; }
        public virtual ICollection<ServicoProdutoTabelaPlano> ServicoProdutoTabelaPlano { get; set; }
        public virtual ICollection<ServicoProdutoTabelaPlanoClassificacaoProduto> ServicoProdutoTabelaPlanoClassificacaoProduto { get; set; }
        public virtual ICollection<ServicoProdutoTabelaPlanoClassificacaoProdutoAlternativa> ServicoProdutoTabelaPlanoClassificacaoProdutoAlternativa { get; set; }
        public virtual ICollection<ServicoProdutoTabelaPlanoClassificacaoProdutoAlternativaHistorico> ServicoProdutoTabelaPlanoClassificacaoProdutoAlternativaHistorico { get; set; }
        public virtual ICollection<ServicoProdutoTabelaPlanoClassificacaoProdutoGrupo> ServicoProdutoTabelaPlanoClassificacaoProdutoGrupo { get; set; }
        public virtual ICollection<ServicoProdutoTabelaPlanoClassificacaoProdutoGrupoHistorico> ServicoProdutoTabelaPlanoClassificacaoProdutoGrupoHistorico { get; set; }
        public virtual ICollection<ServicoProdutoTabelaPlanoHistorico> ServicoProdutoTabelaPlanoHistorico { get; set; }
        public virtual ICollection<ServicoProdutoTabelaPorteTabela> ServicoProdutoTabelaPorteTabela { get; set; }
        public virtual ICollection<ServicoServicoProdutoTabela> ServicoServicoProdutoTabela { get; set; }
        public virtual ICollection<ServicoTraducaoVigencia> ServicoTraducaoVigencia { get; set; }
    }
}
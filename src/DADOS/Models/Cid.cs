﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Cid
    {
        public Cid()
        {
            AtendimentoCid = new HashSet<AtendimentoCid>();
            AtendimentoSusIdCidComplementarNavigation = new HashSet<AtendimentoSus>();
            AtendimentoSusIdCidSecundariaNavigation = new HashSet<AtendimentoSus>();
            CidAgrupamentoIdC = new HashSet<CidAgrupamento>();
            CidAgrupamentoIdCidAgrupadoNavigation = new HashSet<CidAgrupamento>();
            ContaComplementoIdCidComplementarNavigation = new HashSet<ContaComplemento>();
            ContaComplementoIdCidSecundarioNavigation = new HashSet<ContaComplemento>();
            DiagnosticoSecundarioSus = new HashSet<DiagnosticoSecundarioSus>();
            PlanoTratamentoOncologiaProtocolo = new HashSet<PlanoTratamentoOncologiaProtocolo>();
            ProtocoloOncologicoCid = new HashSet<ProtocoloOncologicoCid>();
            ServicoCid = new HashSet<ServicoCid>();
        }

        /// <summary>
        /// identificador do número do CID (classificação internacional de Doenças )
        /// </summary>
        public int IdCid { get; set; }
        /// <summary>
        /// Número do CID (classificação internacional de Doenças )
        /// </summary>
        public string CdCid { get; set; }
        /// <summary>
        /// Texto descritivo da classificação internacional de doenças
        /// </summary>
        public string TxDescricao { get; set; }
        /// <summary>
        /// Identificador do tipo do item do CID (Classificação de internacional de doenças)
        /// </summary>
        public int IdCidCategoria { get; set; }
        /// <summary>
        /// Número do nível do item (Hierarquia para construção de árvores)
        /// </summary>
        public short? NrNivel { get; set; }
        /// <summary>
        /// Identificador de agravo do SUS
        /// </summary>
        public int? IdAgravoTipo { get; set; }
        /// <summary>
        /// Identificador do tipo do CId para o SUS
        /// </summary>
        public int? IdSusTipo { get; set; }
        /// <summary>
        /// Indica se a linha está ativa (exclusão lógica)
        /// </summary>
        public bool? InAtivo { get; set; }
        /// <summary>
        /// Controla a versão da linha
        /// </summary>
        public byte[] RvVersaoLinha { get; set; }
        public bool InEstadiavel { get; set; }

        public virtual TipoDiversos IdAgravoTipoNavigation { get; set; }
        public virtual TipoDiversos IdCidCategoriaNavigation { get; set; }
        public virtual TipoDiversos IdSusTipoNavigation { get; set; }
        public virtual ICollection<AtendimentoCid> AtendimentoCid { get; set; }
        public virtual ICollection<AtendimentoSus> AtendimentoSusIdCidComplementarNavigation { get; set; }
        public virtual ICollection<AtendimentoSus> AtendimentoSusIdCidSecundariaNavigation { get; set; }
        public virtual ICollection<CidAgrupamento> CidAgrupamentoIdC { get; set; }
        public virtual ICollection<CidAgrupamento> CidAgrupamentoIdCidAgrupadoNavigation { get; set; }
        public virtual ICollection<ContaComplemento> ContaComplementoIdCidComplementarNavigation { get; set; }
        public virtual ICollection<ContaComplemento> ContaComplementoIdCidSecundarioNavigation { get; set; }
        public virtual ICollection<DiagnosticoSecundarioSus> DiagnosticoSecundarioSus { get; set; }
        public virtual ICollection<PlanoTratamentoOncologiaProtocolo> PlanoTratamentoOncologiaProtocolo { get; set; }
        public virtual ICollection<ProtocoloOncologicoCid> ProtocoloOncologicoCid { get; set; }
        public virtual ICollection<ServicoCid> ServicoCid { get; set; }
    }
}
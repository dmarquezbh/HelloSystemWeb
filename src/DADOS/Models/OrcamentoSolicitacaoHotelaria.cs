﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrcamentoSolicitacaoHotelaria
    {
        /// <summary>
        /// Identificador único.
        /// </summary>
        public int IdOrcamentoSolicitacaoHotelaria { get; set; }
        /// <summary>
        /// Identificador (FK) para a tabela OrcamentoSolicitacao.
        /// </summary>
        public int IdOrcamentoSolicitacao { get; set; }
        /// <summary>
        /// Identificador (FK) para a tabela TipoDiversos.
        /// </summary>
        public int? IdTipoAcomodacao { get; set; }
        /// <summary>
        /// Quantidade de Diárias desejadas para cada acomodação.
        /// </summary>
        public int? QnDiarias { get; set; }

        public virtual OrcamentoSolicitacao IdOrcamentoSolicitacaoNavigation { get; set; }
        public virtual TipoDiversos IdTipoAcomodacaoNavigation { get; set; }
    }
}
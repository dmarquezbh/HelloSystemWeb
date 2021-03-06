﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProtocoloItem
    {
        public ProtocoloItem()
        {
            ProtocoloAplicacao = new HashSet<ProtocoloAplicacao>();
        }

        public int IdProtocoloItem { get; set; }
        public int IdProtocolo { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public decimal QnDose { get; set; }
        public int IdUnidadeMedida { get; set; }
        public int? IdIntervaloAplicacaoMedicamento { get; set; }
        public int? NrAplicacoes { get; set; }
        public int? QnHoraInicioAplicacao { get; set; }
        public bool? InAtivo { get; set; }
        public int IdUsuario { get; set; }
        public int IdViaAdministracao { get; set; }
        public bool? InBlocoCirurgico { get; set; }
        public bool InDosePreOperatoria { get; set; }
        public bool InNaoSeAplica { get; set; }
        public string TxObservacoes { get; set; }

        public virtual IntervaloAplicacaoMedicamento IdIntervaloAplicacaoMedicamentoNavigation { get; set; }
        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
        public virtual Protocolo IdProtocoloNavigation { get; set; }
        public virtual TipoDiversos IdUnidadeMedidaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual TipoDiversos IdViaAdministracaoNavigation { get; set; }
        public virtual ICollection<ProtocoloAplicacao> ProtocoloAplicacao { get; set; }
    }
}
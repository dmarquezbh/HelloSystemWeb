﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class SolicitacaoProdutoDetalheEntregueLoteProdutoItem
    {
        public int IdSolicitacao { get; set; }
        public int IdLoteProdutoItem { get; set; }
        public int QnItem { get; set; }

        public virtual LoteProdutoItem IdLoteProdutoItemNavigation { get; set; }
        public virtual Solicitacao IdSolicitacaoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoOperadoraServicoProdutoTabelaPlanoHistoricoServico
    {
        public int IdServico { get; set; }
        public int IdServicoProdutoTabela { get; set; }
        public int IdOperadora { get; set; }
        public int IdPlano { get; set; }
        public double VlServico { get; set; }
        public DateTime DtVigencia { get; set; }
        public bool? InPrecoAtual { get; set; }
        public int IdUsuario { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual ServicoOperadoraServicoProdutoTabelaPlano Id { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
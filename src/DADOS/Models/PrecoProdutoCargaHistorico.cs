﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PrecoProdutoCargaHistorico
    {
        public int IdPrecoProdutoCargaHistorico { get; set; }
        public string NrEdicao { get; set; }
        public string TxNomeArquivo { get; set; }
        public int IdServicoProdutoTabela { get; set; }
        public int IdServicoCategoria { get; set; }
        public int QnRegistroImportado { get; set; }
        public int QnProdutoCarga { get; set; }
        public int QnProdutoTratado { get; set; }
        public DateTime DtCarga { get; set; }
        public int QnProdutoAtivado { get; set; }
        public int QnProdutoAtualizado { get; set; }
        public int QnProdutoInserido { get; set; }
        public int QnPrecoAtualizado { get; set; }
        public int QnProdutoDesativado { get; set; }
        public int IdUsuario { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public DateTime? DtVigencia { get; set; }
    }
}
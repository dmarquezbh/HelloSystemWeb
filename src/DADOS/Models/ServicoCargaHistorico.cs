﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoCargaHistorico
    {
        public int IdServicoCargaHistorico { get; set; }
        public string NrEdicao { get; set; }
        public string TxNomeArquivo { get; set; }
        public int IdServicoProdutoTabela { get; set; }
        public int IdServicoCategoria { get; set; }
        public int QnRegistroImportado { get; set; }
        public int QnServicoTratado { get; set; }
        public int QnServicoAssociado { get; set; }
        public int QnServicoTraduzido { get; set; }
        public DateTime DtCarga { get; set; }
        public int IdUsuario { get; set; }
        public byte[] RvVersaoLinha { get; set; }
    }
}
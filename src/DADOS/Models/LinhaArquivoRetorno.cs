﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LinhaArquivoRetorno
    {
        public int IdLinhaArquivo { get; set; }
        public int? IdArquivoUnimed { get; set; }
        public string TxLinhaArquivo { get; set; }
        public int? InSucessoLeitura { get; set; }
        public DateTime? DtLeituraLinha { get; set; }
        public int? IdConta { get; set; }
        public int? IdFechamentoItem { get; set; }
        public int? NrTipoRegistro { get; set; }
        public int? IdErroArquivo { get; set; }
        public int? NrOrdemLinha { get; set; }

        public virtual ArquivoUnimed IdArquivoUnimedNavigation { get; set; }
        public virtual TipoDiversos IdErroArquivoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class DocumentoGeradoHistorico
    {
        public int IdDocumentoGeradoHistorico { get; set; }
        public int IdDocumentoGerado { get; set; }
        public int? IdUnidadeOrigem { get; set; }
        public int? IdUnidadeDestino { get; set; }
        public DateTime DtHistorico { get; set; }
        public int IdUsuario { get; set; }
        public string TxObservacao { get; set; }
    }
}
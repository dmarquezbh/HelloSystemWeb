﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class DocumentoGeral
    {
        public int IdDocumentoGeral { get; set; }
        public string NmDocumento { get; set; }
        public string NmDocumentoCompleto { get; set; }
        public byte[] Documento { get; set; }
        public DateTime DtCadastro { get; set; }
        public int IdUsuario { get; set; }
        public string TxTipo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
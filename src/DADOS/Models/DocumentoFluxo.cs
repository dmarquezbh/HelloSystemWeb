﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class DocumentoFluxo
    {
        public DocumentoFluxo()
        {
            DocumentoFluxoDocumentoFinalidade = new HashSet<DocumentoFluxoDocumentoFinalidade>();
            DocumentoFluxoDocumentoFluxoEtapa = new HashSet<DocumentoFluxoDocumentoFluxoEtapa>();
        }

        public int IdDocumentoFluxo { get; set; }
        public string NmFluxoDocumento { get; set; }
        public bool InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual ICollection<DocumentoFluxoDocumentoFinalidade> DocumentoFluxoDocumentoFinalidade { get; set; }
        public virtual ICollection<DocumentoFluxoDocumentoFluxoEtapa> DocumentoFluxoDocumentoFluxoEtapa { get; set; }
    }
}
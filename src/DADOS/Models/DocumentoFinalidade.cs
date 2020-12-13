﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class DocumentoFinalidade
    {
        public DocumentoFinalidade()
        {
            Documento = new HashSet<Documento>();
            DocumentoExigido = new HashSet<DocumentoExigido>();
            DocumentoFluxoDocumentoFinalidade = new HashSet<DocumentoFluxoDocumentoFinalidade>();
            DocumentoGerado = new HashSet<DocumentoGerado>();
            DocumentoRemessa = new HashSet<DocumentoRemessa>();
            DocumentoRemessaHistorico = new HashSet<DocumentoRemessaHistorico>();
        }

        public int IdDocumentoFinalidade { get; set; }
        public string TxDescricaoFinalidade { get; set; }
        public string TxAbreviatura { get; set; }
        public bool InAtivo { get; set; }
        public int? IdUnidadeDestinoFinal { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual UnidadeOrganizacional IdUnidadeDestinoFinalNavigation { get; set; }
        public virtual ICollection<Documento> Documento { get; set; }
        public virtual ICollection<DocumentoExigido> DocumentoExigido { get; set; }
        public virtual ICollection<DocumentoFluxoDocumentoFinalidade> DocumentoFluxoDocumentoFinalidade { get; set; }
        public virtual ICollection<DocumentoGerado> DocumentoGerado { get; set; }
        public virtual ICollection<DocumentoRemessa> DocumentoRemessa { get; set; }
        public virtual ICollection<DocumentoRemessaHistorico> DocumentoRemessaHistorico { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class DocumentoExigido
    {
        public DocumentoExigido()
        {
            DocumentoExigidoUnidadeOrganizacional = new HashSet<DocumentoExigidoUnidadeOrganizacional>();
            DocumentoGerado = new HashSet<DocumentoGerado>();
            DocumentoexigidoOperadora = new HashSet<DocumentoexigidoOperadora>();
        }

        public int IdDocumentoExigido { get; set; }
        public string NmDocumento { get; set; }
        public int? IdDocumentoTipo { get; set; }
        public int IdDocumentoFinalidade { get; set; }
        public int IdDocumentoEvento { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        /// <summary>
        /// se o documento será solicitado ao finalizar o atendimento
        /// </summary>
        public bool? InExigido { get; set; }
        public int? IdTipoConta { get; set; }

        public virtual DocumentoEvento IdDocumentoEventoNavigation { get; set; }
        public virtual DocumentoFinalidade IdDocumentoFinalidadeNavigation { get; set; }
        public virtual TipoDiversos IdDocumentoTipoNavigation { get; set; }
        public virtual TipoDiversos IdTipoContaNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual ICollection<DocumentoExigidoUnidadeOrganizacional> DocumentoExigidoUnidadeOrganizacional { get; set; }
        public virtual ICollection<DocumentoGerado> DocumentoGerado { get; set; }
        public virtual ICollection<DocumentoexigidoOperadora> DocumentoexigidoOperadora { get; set; }
    }
}
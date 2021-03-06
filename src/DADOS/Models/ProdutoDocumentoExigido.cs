﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProdutoDocumentoExigido
    {
        public int IdProdutoDocumentoExigido { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public int IdFabricante { get; set; }
        public int IdDocumento { get; set; }
        public int? IdPlano { get; set; }
        public DateTime DtInicioExigencia { get; set; }
        public int IdUsuarioDtInicio { get; set; }
        public DateTime? DtFinalExigencia { get; set; }
        public int? IdUsuarioDtFinal { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual ProdutoDetalheFabricante Id { get; set; }
        public virtual Documento IdDocumentoNavigation { get; set; }
        public virtual Plano IdPlanoNavigation { get; set; }
        public virtual Usuario IdUsuarioDtFinalNavigation { get; set; }
        public virtual Usuario IdUsuarioDtInicioNavigation { get; set; }
    }
}
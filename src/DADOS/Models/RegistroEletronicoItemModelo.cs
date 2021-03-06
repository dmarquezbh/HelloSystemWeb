﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RegistroEletronicoItemModelo
    {
        public RegistroEletronicoItemModelo()
        {
            RegistroEletronicoItem = new HashSet<RegistroEletronicoItem>();
            RegistroEletronicoItemModeloAtributo = new HashSet<RegistroEletronicoItemModeloAtributo>();
            RegistroEletronicoItemModeloHistorico = new HashSet<RegistroEletronicoItemModeloHistorico>();
        }

        public int IdRegistroEletronicoItemModelo { get; set; }
        public int IdRegistroEletronicoModelo { get; set; }
        public int IdTipoRegistroEletronicoItem { get; set; }
        public int IdTipoOcorrencia { get; set; }
        public string NmRegistroEletronicoItemModelo { get; set; }
        public int NrVersao { get; set; }
        public string TxHtmlConteudoModelo { get; set; }
        public bool InEditavel { get; set; }
        public bool InObrigatorio { get; set; }
        public bool InAtivo { get; set; }

        public virtual RegistroEletronicoModelo IdRegistroEletronicoModeloNavigation { get; set; }
        public virtual TipoDiversos IdTipoOcorrenciaNavigation { get; set; }
        public virtual TipoDiversos IdTipoRegistroEletronicoItemNavigation { get; set; }
        public virtual ICollection<RegistroEletronicoItem> RegistroEletronicoItem { get; set; }
        public virtual ICollection<RegistroEletronicoItemModeloAtributo> RegistroEletronicoItemModeloAtributo { get; set; }
        public virtual ICollection<RegistroEletronicoItemModeloHistorico> RegistroEletronicoItemModeloHistorico { get; set; }
    }
}
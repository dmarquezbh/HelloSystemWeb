﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LeitoUnidadeFluxo
    {
        public int IdLeitoUnidadeFluxo { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public int IdStatusInicial { get; set; }
        public int IdStatusFinal { get; set; }
        public int? NrTempoEspera { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool? InPodeCancelar { get; set; }

        public virtual TipoDiversos IdStatusFinalNavigation { get; set; }
        public virtual TipoDiversos IdStatusInicialNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class DocumentoLoteMedico
    {
        public int IdDocumentoLote { get; set; }
        public int? IdAtendimento { get; set; }
        public int? IdMedicoAtendimento { get; set; }
        public DateTime? DtAtendimentoAtendimento { get; set; }
        public int? IdEspecialidade { get; set; }
        public int IdMedico { get; set; }
        public DateTime? DtAtendimento { get; set; }
        public bool InImpresso { get; set; }
        public DateTime DtImpressao { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual AtendimentoMedico AtendimentoMedico { get; set; }
        public virtual DocumentoLote IdDocumentoLoteNavigation { get; set; }
        public virtual TipoDiversos IdEspecialidadeNavigation { get; set; }
        public virtual Pessoa IdMedicoNavigation { get; set; }
    }
}
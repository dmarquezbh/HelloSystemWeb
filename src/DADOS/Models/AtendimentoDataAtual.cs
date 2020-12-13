﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AtendimentoDataAtual
    {
        public int IdAtendimento { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdPlano { get; set; }
        public string NrCartaoIdentificacao { get; set; }
        public string NrMatricula { get; set; }
        public DateTime? DtValidadeCartao { get; set; }
        public string NmTitular { get; set; }
        public DateTime? DtAtendimento { get; set; }
        public DateTime? DtAltaMedica { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public int? IdTipoInternacao { get; set; }
        public int? IdTipoInternacaoPaciente { get; set; }
        public int? IdProcedencia { get; set; }
        public int? IdTipoAtendimento { get; set; }
        public int? IdStatusAtendimento { get; set; }
        public string TxCondicaoPgto { get; set; }
        public string NrAutorizacao { get; set; }
        public int? IdMedicoPrincipal { get; set; }
        public bool? InSemOnus { get; set; }
        public string TxAutorizacaoSemOnus { get; set; }
        public string NmEmpresa { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool InDescParticular { get; set; }
        public int? IdJustificativaCancelamento { get; set; }
        public DateTime? DtVenccarenc { get; set; }
        public string TxIntercambio { get; set; }
        public int? IdProcedimentoCiha { get; set; }
        public int? IdCidCiha { get; set; }
    }
}
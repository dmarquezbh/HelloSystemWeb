﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RecursoGlosaReenvio
    {
        public string Sselect { get; set; }
        public string Paciente { get; set; }
        public int Conta { get; set; }
        public int? Lote { get; set; }
        public DateTime? Atendimento { get; set; }
        public DateTime? Alta { get; set; }
        public string Cartao { get; set; }
        public string Matricula { get; set; }
        public string Autorizacao { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Motivo { get; set; }
        public double? Glosa { get; set; }
        public double? Recurso { get; set; }
        public string Titulo { get; set; }
        public string Justificativa { get; set; }
        public double? Valor { get; set; }
        public string Operadora { get; set; }
        public DateTime? DtImpressao { get; set; }
        public string TxCabecalho { get; set; }
        public string TxCorpo { get; set; }
        public string TxContato { get; set; }
        public string TxAssinatura { get; set; }
        public int IdCartarecurso { get; set; }
        public double? QnGlosada { get; set; }
        public int? QnRecursada { get; set; }
        public double QdItem { get; set; }
        public string NmConsumoMinimo { get; set; }
        public double VlUnitario { get; set; }
        public int IdAtendimento { get; set; }
        public string Guiasenha { get; set; }
        public int? NrCartaRemessa { get; set; }
        public string TxRazaoSocial { get; set; }
        public string TxObservacoes { get; set; }
        public int? InReenvio { get; set; }
        public string DtLancamento { get; set; }
        public string DtVencimentoRecurso { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class FatoFaturamentoTeste
    {
        public string DtwrAltaMedica { get; set; }
        public DateTime? DtwrFaturamento { get; set; }
        public string DtFechamentoConta { get; set; }
        public int IdAtendimento { get; set; }
        public int IdConta { get; set; }
        public int? IdPaciente { get; set; }
        public int IdPessoaLocalidade { get; set; }
        public int IdFaixaEtaria { get; set; }
        public int? IdSexo { get; set; }
        public int IdNotaEmitida { get; set; }
        public int IdBairro { get; set; }
        public int IdCidade { get; set; }
        public int IdUf { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public int InPa { get; set; }
        public int? IdUnidadeAtendimento { get; set; }
        public int IdTipoSetorAtendimento { get; set; }
        public int IdCid { get; set; }
        public string IdGrupoOperadora { get; set; }
        public int IdOperadora { get; set; }
        public string IdOperadoraTipo { get; set; }
        public int? IdMedicoEntrada { get; set; }
        public int IdEspecialidadeEntrada { get; set; }
        public int IdProcedimento { get; set; }
        public int IdMedicoSolicitante { get; set; }
        public int IdEspecialidadeSolicitante { get; set; }
        public int IdMedicoAlta { get; set; }
        public int IdEspecialidadeAlta { get; set; }
        public int IdMedicoCirurgia { get; set; }
        public int IdEspecialidadeCirurgia { get; set; }
        public int IdInternoExterno { get; set; }
        public int IdParticular { get; set; }
        public double? PermanenciaUi { get; set; }
        public double? PermanenciaUti { get; set; }
        public double? PermanenciaTotal { get; set; }
        public decimal VlFaturado { get; set; }
        public decimal VlGlosado { get; set; }
        public decimal VlFaturamentoIndevido { get; set; }
        public decimal VlFaturamentoAcrescimo { get; set; }
        public decimal VlFaturamentoLiquido { get; set; }
        public int? InAtendimentoCirurgico { get; set; }
        public int IdUnidadeOrganizacionalFaturamento { get; set; }
        public int IdClassificacaoFaturamento { get; set; }
    }
}
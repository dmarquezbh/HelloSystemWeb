﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class IntegracaoAgendaMarcacoesPaciente
    {
        public int IdAgendamento { get; set; }
        public int? IdPaciente { get; set; }
        public string Paciente { get; set; }
        public DateTime DtAgenda { get; set; }
        public int IdUnidade { get; set; }
        public string Unidade { get; set; }
        public int? IdMedico { get; set; }
        public string Medico { get; set; }
        public string Equipamento { get; set; }
        public string Operadora { get; set; }
        public int IdProcedimento { get; set; }
        public string Procedimento { get; set; }
        public string Tipo { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class IntegracaoAgendaAgendamentos
    {
        public string NomeHospital { get; set; }
        public string TelefoneHospital { get; set; }
        public int IdAgenda { get; set; }
        public int? IdPaciente { get; set; }
        public DateTime DataHoraAgenda { get; set; }
        public DateTime? DataHoraMarcacao { get; set; }
        public string Telefone { get; set; }
        public string Paciente { get; set; }
        public string EMail { get; set; }
        public int IdProcedimento { get; set; }
        public string Procedimento { get; set; }
        public string Tipo { get; set; }
        public string Unidade { get; set; }
        public int IdSetor { get; set; }
        public string NmMedico { get; set; }
    }
}
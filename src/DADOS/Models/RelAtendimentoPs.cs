﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RelAtendimentoPs
    {
        public int Atendimento { get; set; }
        /// <summary>
        /// SQL_Latin1_General_CP1_CI_AS
        /// </summary>
        public string Paciente { get; set; }
        public DateTime? DataAtendimento { get; set; }
        public DateTime? DataAlta { get; set; }
        public int? Unidade { get; set; }
        /// <summary>
        /// SQL_Latin1_General_CP1_CI_AS
        /// </summary>
        public string Especialidade { get; set; }
        /// <summary>
        /// SQL_Latin1_General_CP1_CI_AS
        /// </summary>
        public string Medico { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProfissionalSaudeIi
    {
        public int IdProfissionalSaude { get; set; }
        public string NmProfissionalSaude { get; set; }
        public int? NrConselho { get; set; }
        public string UfConselho { get; set; }
        public int? IdConselho { get; set; }
        public string CdCpf { get; set; }
        public bool InAtivo { get; set; }
    }
}
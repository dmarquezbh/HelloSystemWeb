﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ClinicaUnidadeOrganizacionalMedico
    {
        public int IdClinica { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public int IdMedico { get; set; }
        public bool InAtivo { get; set; }
    }
}
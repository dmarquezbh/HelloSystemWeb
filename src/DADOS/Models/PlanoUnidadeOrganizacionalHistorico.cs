﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PlanoUnidadeOrganizacionalHistorico
    {
        public int IdPlano { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public DateTime DtHistorico { get; set; }
        public int IdHistorico { get; set; }

        public virtual PlanoUnidadeOrganizacionalCredenciada Id { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class UnidadeOrganizacionalColaboradorHorario
    {
        public int IdPessoa { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public int IdHorarioDiaSemana { get; set; }
        public bool InPlantao { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual UnidadeOrganizacionalColaborador Id { get; set; }
        public virtual HorarioDiaSemana IdHorarioDiaSemanaNavigation { get; set; }
    }
}
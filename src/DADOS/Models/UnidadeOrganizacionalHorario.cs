﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class UnidadeOrganizacionalHorario
    {
        public int IdUnidadeOrganizacional { get; set; }
        public int IdHorarioDiaSemana { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual HorarioDiaSemana IdHorarioDiaSemanaNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class UnidadeOrganizacionalHorarioAgendaReserva
    {
        public int IdHorarioAgenda { get; set; }
        public DateTime DtReserva { get; set; }
        public int? IdMedico { get; set; }
        public int IdHorarioReservaBase { get; set; }
        public int? IdRecurso { get; set; }
        public DateTime DtMarcacao { get; set; }

        public virtual UnidadeOrganizacionalHorarioAgenda IdHorarioAgendaNavigation { get; set; }
        public virtual Pessoa IdMedicoNavigation { get; set; }
        public virtual Recurso IdRecursoNavigation { get; set; }
    }
}
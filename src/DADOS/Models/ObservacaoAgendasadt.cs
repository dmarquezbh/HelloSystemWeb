﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ObservacaoAgendasadt
    {
        public int IdObsAgenda { get; set; }
        public int? IdMedico { get; set; }
        public int? IdRecurso { get; set; }
        public string TxObservacaoAgenda { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }

        public virtual Pessoa IdMedicoNavigation { get; set; }
        public virtual Recurso IdRecursoNavigation { get; set; }
    }
}
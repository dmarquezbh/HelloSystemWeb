﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AgendaccEquipamento
    {
        public int IdIndex { get; set; }
        public int? IdAgendacc { get; set; }
        public int? IdRecurso { get; set; }

        public virtual Recurso IdRecursoNavigation { get; set; }
    }
}
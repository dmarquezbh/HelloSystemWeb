﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class GrupoExame
    {
        public GrupoExame()
        {
            ExamePrioridade = new HashSet<ExamePrioridade>();
        }

        public int IdGrupoExame { get; set; }
        public string NmGrupoExame { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual ICollection<ExamePrioridade> ExamePrioridade { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OperadoraEspecialidade
    {
        public OperadoraEspecialidade()
        {
            OperadoraEspecialidadeHistorico = new HashSet<OperadoraEspecialidadeHistorico>();
        }

        public int IdOperadora { get; set; }
        public int IdEspecialidade { get; set; }
        public int IdStatus { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual TipoDiversos IdEspecialidadeNavigation { get; set; }
        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual ICollection<OperadoraEspecialidadeHistorico> OperadoraEspecialidadeHistorico { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CirurgiaFuncaoTipo
    {
        public CirurgiaFuncaoTipo()
        {
            DispensacaoEnfermagem = new HashSet<DispensacaoEnfermagem>();
            EquipeResponsavel = new HashSet<EquipeResponsavel>();
        }

        public int IdCirurgiaFuncaoTipo { get; set; }
        public string TxDescricao { get; set; }

        public virtual ICollection<DispensacaoEnfermagem> DispensacaoEnfermagem { get; set; }
        public virtual ICollection<EquipeResponsavel> EquipeResponsavel { get; set; }
    }
}
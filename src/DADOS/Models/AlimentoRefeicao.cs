﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AlimentoRefeicao
    {
        public int IdAlimento { get; set; }
        public int IdRefeicao { get; set; }
        public decimal QnAlimento { get; set; }
        public bool InAtivo { get; set; }

        public virtual Refeicao IdRefeicaoNavigation { get; set; }
    }
}
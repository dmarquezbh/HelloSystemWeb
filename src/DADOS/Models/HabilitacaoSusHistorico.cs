﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class HabilitacaoSusHistorico
    {
        public int IdTipoHabilitacaoHistorico { get; set; }
        public int IdTipoHabilitacao { get; set; }
        public string TxCompetencia { get; set; }

        public virtual TipoDiversos IdTipoHabilitacaoNavigation { get; set; }
    }
}
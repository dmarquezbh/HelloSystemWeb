﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ExameTempoLiberacaoHistorico
    {
        public int IdExameTempoLiberacaoHistorico { get; set; }
        public DateTime DtExameTempoLiberacaoHistoricoUtc { get; set; }
        public int IdExameTempoLiberacao { get; set; }
        public int IdExame { get; set; }
        public int IdUsuario { get; set; }
        public int? NrMinutosUrgente { get; set; }
        public int? NrMinutosEmergencial { get; set; }
        public int? NrMinutosNormalCti { get; set; }
        public int? NrMinutosNormalInternacao { get; set; }
        public int? NrMinutosNormalRotina { get; set; }
    }
}
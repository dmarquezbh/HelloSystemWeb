﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ReversaoGlosaParcialLog
    {
        public int IdReversaoGlosaParcialLog { get; set; }
        public int IdReversaoGlosaParcial { get; set; }
        public int IdConta { get; set; }
        public int IdFechamentoItem { get; set; }
        public int IdUsuario { get; set; }
        public int? IdCartarecurso { get; set; }
        public DateTime DtReversao { get; set; }
        public decimal VlRevertido { get; set; }
        public DateTime DtCadastro { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioOperacao { get; set; }

        public virtual Usuario IdUsuarioOperacaoNavigation { get; set; }
    }
}
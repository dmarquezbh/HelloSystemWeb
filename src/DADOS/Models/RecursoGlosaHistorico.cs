﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RecursoGlosaHistorico
    {
        public int IdRecursoGlosaHistorico { get; set; }
        public int IdFechamentoItem { get; set; }
        public int IdConta { get; set; }
        public double? VlRecursado { get; set; }
        public int? QnRecursada { get; set; }
        public double? VlRecursadoTotal { get; set; }
        public string TxObservacoes { get; set; }
        public int IdJustificativaRecurso { get; set; }
        public DateTime? DtRecurso { get; set; }
        public int IdUsuario { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioOperacao { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual Usuario IdUsuarioOperacaoNavigation { get; set; }
    }
}
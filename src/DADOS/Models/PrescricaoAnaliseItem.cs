﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PrescricaoAnaliseItem
    {
        public int IdSolicitacaoPdEnfermagem { get; set; }
        public bool InAnalisado { get; set; }
        public bool InNaoAplicavel { get; set; }
        public bool InNaoAprovado { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? DtCriacao { get; set; }

        public virtual SolicitacaoPdEnfermagem IdSolicitacaoPdEnfermagemNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
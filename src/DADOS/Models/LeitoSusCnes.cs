﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LeitoSusCnes
    {
        public LeitoSusCnes()
        {
            LeitoCnesAcomodacao = new HashSet<LeitoCnesAcomodacao>();
        }

        public int IdLeitoCnes { get; set; }
        public int IdTipoLeitoCnes { get; set; }
        public int IdTipoEspecialidadeLeitoCnes { get; set; }
        public int QnLeito { get; set; }
        public bool? InAtivo { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public DateTime DtCadastro { get; set; }
        public int? IdUsuarioExclusao { get; set; }
        public DateTime? DtExclusao { get; set; }

        public virtual TipoDiversos IdTipoEspecialidadeLeitoCnesNavigation { get; set; }
        public virtual TipoDiversos IdTipoLeitoCnesNavigation { get; set; }
        public virtual ICollection<LeitoCnesAcomodacao> LeitoCnesAcomodacao { get; set; }
    }
}
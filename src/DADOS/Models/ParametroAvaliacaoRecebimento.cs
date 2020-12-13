﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ParametroAvaliacaoRecebimento
    {
        public ParametroAvaliacaoRecebimento()
        {
            InspecaoRecebimentoParametroAvaliacao = new HashSet<InspecaoRecebimentoParametroAvaliacao>();
        }

        public int IdParametroAvaliacao { get; set; }
        public string NmParametroAvaliacao { get; set; }
        public int VlParametroAvaliacao { get; set; }
        public int? IdTipoAvaliacao { get; set; }
        public DateTime? DtCadastro { get; set; }
        public int? IdUsuario { get; set; }
        public bool? InAtivo { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioExcluiu { get; set; }
        public int? VlNota { get; set; }
        public int? IdGrupoInspecaoRecebimento { get; set; }

        public virtual GrupoInspecaoRecebimento IdGrupoInspecaoRecebimentoNavigation { get; set; }
        public virtual TipoDiversos IdTipoAvaliacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioExcluiuNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<InspecaoRecebimentoParametroAvaliacao> InspecaoRecebimentoParametroAvaliacao { get; set; }
    }
}
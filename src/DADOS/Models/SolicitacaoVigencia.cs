﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class SolicitacaoVigencia
    {
        public int IdSolicitacaoVigencia { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtInicio { get; set; }
        public int IdUsuario { get; set; }
        public int QnPermitido { get; set; }
        public int? IdUnidadeSolicitante { get; set; }
        public bool InAtivo { get; set; }
        public DateTime? DtFim { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioExcluiu { get; set; }

        public virtual UnidadeOrganizacional IdUnidadeSolicitanteNavigation { get; set; }
        public virtual Usuario IdUsuarioExcluiuNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
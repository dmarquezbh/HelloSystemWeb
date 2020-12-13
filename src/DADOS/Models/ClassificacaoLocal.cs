﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ClassificacaoLocal
    {
        public ClassificacaoLocal()
        {
            ClassificacaoChamada = new HashSet<ClassificacaoChamada>();
            ClassificacaoFluxo = new HashSet<ClassificacaoFluxo>();
            ClassificacaoLocalStatusSenha = new HashSet<ClassificacaoLocalStatusSenha>();
        }

        public int IdClassificacaoLocal { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public string NmClassificacaoLocal { get; set; }
        public int IdClassificacaoLocalTipo { get; set; }
        public bool? InAtivo { get; set; }

        public virtual TipoDiversos IdClassificacaoLocalTipoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual ICollection<ClassificacaoChamada> ClassificacaoChamada { get; set; }
        public virtual ICollection<ClassificacaoFluxo> ClassificacaoFluxo { get; set; }
        public virtual ICollection<ClassificacaoLocalStatusSenha> ClassificacaoLocalStatusSenha { get; set; }
    }
}
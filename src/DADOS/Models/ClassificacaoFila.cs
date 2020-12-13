﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ClassificacaoFila
    {
        public ClassificacaoFila()
        {
            ClassificacaoFluxo = new HashSet<ClassificacaoFluxo>();
            ClassificacaoSenha = new HashSet<ClassificacaoSenha>();
        }

        public int IdClassificacaoFila { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public string NmFila { get; set; }
        public string TxSigla { get; set; }
        public bool? InAtivo { get; set; }
        /// <summary>
        /// se a fila passa por triagem
        /// </summary>
        public bool? InTriagem { get; set; }
        /// <summary>
        /// se o campo será visível na tela de retirar a senha
        /// </summary>
        public bool? InVisivel { get; set; }

        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual ICollection<ClassificacaoFluxo> ClassificacaoFluxo { get; set; }
        public virtual ICollection<ClassificacaoSenha> ClassificacaoSenha { get; set; }
    }
}
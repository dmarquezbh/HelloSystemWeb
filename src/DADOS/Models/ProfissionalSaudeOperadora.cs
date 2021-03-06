﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProfissionalSaudeOperadora
    {
        /// <summary>
        /// identificador do profissional de saúde
        /// </summary>
        public int IdProfissional { get; set; }
        public int IdOperadora { get; set; }
        public string NrCredenciamento { get; set; }
        /// <summary>
        /// não é a exclusão lógica, campo mostra se o profissional está credenciado
        /// </summary>
        public bool? InAtivado { get; set; }
        /// <summary>
        /// exclusão lógica
        /// </summary>
        public bool? InAtivo { get; set; }

        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual Pessoa IdProfissionalNavigation { get; set; }
    }
}
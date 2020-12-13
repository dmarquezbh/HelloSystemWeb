﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LaboratorioUnidadeSolicitanteExcecao
    {
        /// <summary>
        /// exame que não será permitido lançar para a unidade
        /// </summary>
        public int IdExame { get; set; }
        /// <summary>
        /// unidade que não poderá lançar o exame
        /// </summary>
        public int IdUnidadeOrganizacional { get; set; }
        /// <summary>
        /// campo não utilizado,tipo tabela 104
        /// </summary>
        public int IdPrioridadeTipo { get; set; }
        /// <summary>
        /// exclusão lógica
        /// </summary>
        public bool? InAtivo { get; set; }

        public virtual Exame IdExameNavigation { get; set; }
        public virtual TipoDiversos IdPrioridadeTipoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
    }
}
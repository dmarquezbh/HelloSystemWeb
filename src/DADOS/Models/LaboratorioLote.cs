﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LaboratorioLote
    {
        /// <summary>
        /// identificador único do lote
        /// </summary>
        public int IdLaboratorioLote { get; set; }
        /// <summary>
        /// data que o lote foi enviado para o laboratório de apoio
        /// </summary>
        public DateTime? DtEnvio { get; set; }
        /// <summary>
        /// usuário que criou o lote
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// tipo tabela 395
        /// </summary>
        public int IdStatusLote { get; set; }
        public int? IdSessaoTecnica { get; set; }

        public virtual UnidadeOrganizacional IdSessaoTecnicaNavigation { get; set; }
        public virtual TipoDiversos IdStatusLoteNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
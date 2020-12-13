﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class DocumentoEmprestimoHistorico
    {
        public int IdEmprestimoHistorico { get; set; }
        /// <summary>
        /// identifica qual emprestimo foi realizado na tabela DocumentoEmprestimo
        /// </summary>
        public int IdEmprestimo { get; set; }
        /// <summary>
        /// Identifica o usuário que realizou a alteração
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// novo status que foi alterado, tabela 386
        /// </summary>
        public int IdStatusEmprestimo { get; set; }
        /// <summary>
        /// data que ocorreu a alteração na tabela DocumentoEmprestimo
        /// </summary>
        public DateTime DtOcorrencia { get; set; }

        public virtual DocumentoEmprestimo IdEmprestimoNavigation { get; set; }
        public virtual TipoDiversos IdStatusEmprestimoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LaboratorioHemocultura
    {
        /// <summary>
        /// código único da etiqueta de hemocultura
        /// </summary>
        public int IdLaboratorioHemocultura { get; set; }
        /// <summary>
        /// data e hora do sistema que foi criada a etiqueta de hemocultura
        /// </summary>
        public DateTime DtCadastro { get; set; }
        public string TxEtiqueta { get; set; }
    }
}
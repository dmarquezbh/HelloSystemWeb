﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CargaTaxas
    {
        public int IdServicoProdutoTabela { get; set; }
        public int IdOperadora { get; set; }
        /// <summary>
        /// SQL_Latin1_General_CP1_CI_AS
        /// </summary>
        public string NmOperadora { get; set; }
        public bool? InAtivo { get; set; }
        public bool InReferencia { get; set; }
    }
}
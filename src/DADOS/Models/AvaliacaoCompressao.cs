﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AvaliacaoCompressao
    {
        public string TableName { get; set; }
        public string IndexName { get; set; }
        public long? Rowcnt { get; set; }
        public int Partition { get; set; }
        public int IndexId { get; set; }
        /// <summary>
        /// Latin1_General_CI_AS_KS_WS
        /// </summary>
        public string IndexType { get; set; }
        public decimal? PercentUpdate { get; set; }
        public decimal? PercentScan { get; set; }
    }
}
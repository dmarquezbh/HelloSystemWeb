﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class SismamaCargaHistorico
    {
        public SismamaCargaHistorico()
        {
            SismamaCargaLog = new HashSet<SismamaCargaLog>();
        }

        public int IdSismamaCargaHistorico { get; set; }
        public string TxNomeArquivo { get; set; }
        public DateTime DtCarga { get; set; }
        public int IdUsuario { get; set; }

        public virtual ICollection<SismamaCargaLog> SismamaCargaLog { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RetornoFnIdentificaFchItemUnimed
    {
        public int IdRetornoFuncao { get; set; }
        public DateTime DtRegistro { get; set; }
        public int IdConta { get; set; }
        public string CdItem { get; set; }
        public int IdFechamentoItemRetornado { get; set; }
        public int IdPrimeiroArquivoRetornoDaCompetencia { get; set; }

        public virtual FechamentoItem Id { get; set; }
    }
}
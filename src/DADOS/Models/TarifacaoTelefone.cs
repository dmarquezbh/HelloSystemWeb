﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TarifacaoTelefone
    {
        public string NrRamal { get; set; }
        public DateTime DtUtilizacao { get; set; }
        public int NrTronco { get; set; }
        public string NrDiscado { get; set; }
        public string TxLocalidade { get; set; }
        public string TxUf { get; set; }
        public string HrDuracao { get; set; }
        public string MnDuracao { get; set; }
        public string SgDuracao { get; set; }
        public decimal VlBasico { get; set; }
        public decimal VlCobrado { get; set; }
        public string TxTipo { get; set; }
        public string NmUnidadeOrganizacional { get; set; }
        public string NmCentroCusto { get; set; }
        public bool InCobrado { get; set; }
    }
}
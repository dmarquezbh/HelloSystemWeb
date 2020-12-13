﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ImpostoRetido
    {
        public ImpostoRetido()
        {
            ContaReceberImpostoRetido = new HashSet<ContaReceberImpostoRetido>();
            GuiaFiscal = new HashSet<GuiaFiscal>();
            ParcelaContaReceberBaixa = new HashSet<ParcelaContaReceberBaixa>();
        }

        public int IdImpostoRetido { get; set; }
        public string NmImpostoRetido { get; set; }
        public bool InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int? IdTipoImpostoRetido { get; set; }

        public virtual TipoDiversos IdTipoImpostoRetidoNavigation { get; set; }
        public virtual ICollection<ContaReceberImpostoRetido> ContaReceberImpostoRetido { get; set; }
        public virtual ICollection<GuiaFiscal> GuiaFiscal { get; set; }
        public virtual ICollection<ParcelaContaReceberBaixa> ParcelaContaReceberBaixa { get; set; }
    }
}
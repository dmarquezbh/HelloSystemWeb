﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PlanoRede
    {
        public PlanoRede()
        {
            Plano = new HashSet<Plano>();
        }

        public int IdRede { get; set; }
        public string TxDescricao { get; set; }
        public int IdOperadora { get; set; }
        public bool InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public double? VlCh { get; set; }

        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual ICollection<Plano> Plano { get; set; }
    }
}
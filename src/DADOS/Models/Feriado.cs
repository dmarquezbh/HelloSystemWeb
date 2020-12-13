﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Feriado
    {
        public Feriado()
        {
            FeriadoData = new HashSet<FeriadoData>();
        }

        public int IdFeriado { get; set; }
        public string TxDescricao { get; set; }
        public bool? InFeriadoFixo { get; set; }
        public int IdFeriadoTipo { get; set; }
        public int? IdUf { get; set; }
        public int? IdLocalidade { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual LogLocalidade IdLocalidadeNavigation { get; set; }
        public virtual Uf IdUfNavigation { get; set; }
        public virtual ICollection<FeriadoData> FeriadoData { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TisstipoItem
    {
        public int IdTipoItem { get; set; }
        public int IdTipo { get; set; }
        public string TxValorTiss { get; set; }
        public string TxDescricaoTiss { get; set; }

        public virtual Tisstipo IdTipoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class JustificativaBloqueio
    {
        public JustificativaBloqueio()
        {
            AgendaSadt = new HashSet<AgendaSadt>();
        }

        public int IdJustificativaBloqueio { get; set; }
        public string TxDescricaoJustBloqueio { get; set; }

        public virtual ICollection<AgendaSadt> AgendaSadt { get; set; }
    }
}
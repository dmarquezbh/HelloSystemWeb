﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Pagina
    {
        public Pagina()
        {
            LgpdLog = new HashSet<LgpdLog>();
        }

        public int IdPagina { get; set; }
        public string NmPagina { get; set; }
        public string TxExibePagina { get; set; }

        public virtual ICollection<LgpdLog> LgpdLog { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Interface
    {
        public Interface()
        {
            Analisador = new HashSet<Analisador>();
        }

        public int IdInterface { get; set; }
        public string NmInterface { get; set; }

        public virtual ICollection<Analisador> Analisador { get; set; }
    }
}
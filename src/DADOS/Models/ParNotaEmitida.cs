﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ParNotaEmitida
    {
        public int IdPar { get; set; }
        public int IdNota2 { get; set; }
        public int IdNota3 { get; set; }

        public virtual NotaEmitida IdNota2Navigation { get; set; }
        public virtual NotaEmitida IdNota3Navigation { get; set; }
    }
}
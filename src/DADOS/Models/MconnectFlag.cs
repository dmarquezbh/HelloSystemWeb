﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class MconnectFlag
    {
        public string Exame { get; set; }
        public string Amostra { get; set; }
        public int SequenciaRepeticao { get; set; }
        public string Flag { get; set; }
        public string Descricao { get; set; }

        public virtual MconnectExame MconnectExame { get; set; }
    }
}
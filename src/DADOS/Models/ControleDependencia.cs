﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ControleDependencia
    {
        public int IdControlePai { get; set; }
        public int IdControleFilho { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual Controle IdControleFilhoNavigation { get; set; }
        public virtual Controle IdControlePaiNavigation { get; set; }
    }
}
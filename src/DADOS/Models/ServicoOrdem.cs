﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoOrdem
    {
        public int IdServicoOrdem { get; set; }
        public int IdConta { get; set; }
        public int IdContaItem { get; set; }
        public int NrOrdem { get; set; }

        public virtual ContaItem IdContaItemNavigation { get; set; }
        public virtual Conta IdContaNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AtributoDependente
    {
        public int IdAtributo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int IdAtributoDependente { get; set; }

        public virtual Atributo IdAtributoDependenteNavigation { get; set; }
        public virtual Atributo IdAtributoNavigation { get; set; }
    }
}
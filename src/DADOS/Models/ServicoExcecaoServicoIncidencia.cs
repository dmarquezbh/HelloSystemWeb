﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoExcecaoServicoIncidencia
    {
        public int IdServico { get; set; }
        public int IdOperadora { get; set; }
        public int IdAtributo { get; set; }
        public string VlIncidencia { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual ServicoExcecao Id { get; set; }
        public virtual Atributo IdAtributoNavigation { get; set; }
    }
}
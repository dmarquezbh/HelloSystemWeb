﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RegistroEletronicoModeloExigido
    {
        public int IdRegistroEletronicoModelo { get; set; }
        public int IdRegistroEletronicoModeloExigido { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public bool? InAtivo { get; set; }

        public virtual RegistroEletronicoModelo IdRegistroEletronicoModeloExigidoNavigation { get; set; }
        public virtual RegistroEletronicoModelo IdRegistroEletronicoModeloNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
    }
}
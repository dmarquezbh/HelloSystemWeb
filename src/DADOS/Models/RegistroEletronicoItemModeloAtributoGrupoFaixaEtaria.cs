﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RegistroEletronicoItemModeloAtributoGrupoFaixaEtaria
    {
        public int IdRegistroEletronicoItemModeloAtributo { get; set; }
        public int IdGrupoFaixaEtaria { get; set; }
        public bool? InAtivo { get; set; }

        public virtual GrupoFaixaEtaria IdGrupoFaixaEtariaNavigation { get; set; }
        public virtual RegistroEletronicoItemModeloAtributo IdRegistroEletronicoItemModeloAtributoNavigation { get; set; }
    }
}
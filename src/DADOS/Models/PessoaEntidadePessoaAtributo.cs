﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PessoaEntidadePessoaAtributo
    {
        public PessoaEntidadePessoaAtributo()
        {
            PessoaCaracteristica = new HashSet<PessoaCaracteristica>();
        }

        public int IdPessoaEntidade { get; set; }
        public int IdAtributo { get; set; }
        public bool InObrigatorio { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool? InAtivo { get; set; }

        public virtual Atributo IdAtributoNavigation { get; set; }
        public virtual PessoaEntidade IdPessoaEntidadeNavigation { get; set; }
        public virtual ICollection<PessoaCaracteristica> PessoaCaracteristica { get; set; }
    }
}
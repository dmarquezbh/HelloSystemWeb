﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RegistroEletronicoTipoPessoaEntidade
    {
        public int IdTipoRegistroEletronico { get; set; }
        public int IdPessoaEntidade { get; set; }

        public virtual PessoaEntidade IdPessoaEntidadeNavigation { get; set; }
        public virtual TipoDiversos IdTipoRegistroEletronicoNavigation { get; set; }
    }
}
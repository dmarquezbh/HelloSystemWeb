﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ArquivoRemessa
    {
        public int IdPessoa { get; set; }
        public int? NRemessa { get; set; }

        public virtual Pessoa IdPessoaNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ClassificacaoLocalStatusSenha
    {
        public int IdClassificacaoLocal { get; set; }
        public int IdStatusSenha { get; set; }
        public int InAtivo { get; set; }

        public virtual ClassificacaoLocal IdClassificacaoLocalNavigation { get; set; }
        public virtual TipoDiversos IdStatusSenhaNavigation { get; set; }
    }
}
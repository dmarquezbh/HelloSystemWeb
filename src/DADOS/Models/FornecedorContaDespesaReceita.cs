﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class FornecedorContaDespesaReceita
    {
        public int IdFornecedorContadespesareceita { get; set; }
        public int IdFornecedor { get; set; }
        public int IdContadespesareceita { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool? InAtivo { get; set; }

        public virtual ContaDespesaReceita IdContadespesareceitaNavigation { get; set; }
    }
}
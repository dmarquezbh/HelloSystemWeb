﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ContaItemProdutoNotaEntradaSus
    {
        public int IdContaItemProduto { get; set; }
        public string NrNota { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public string CdCnpj { get; set; }
        public string NrLote { get; set; }

        public virtual ContaItemProduto IdContaItemProdutoNavigation { get; set; }
    }
}
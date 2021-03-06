﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TextoPadrao
    {
        public TextoPadrao()
        {
            TextoPadraoPrescricaoItemTipo = new HashSet<TextoPadraoPrescricaoItemTipo>();
            TextoPadraoProdutoDetalhe = new HashSet<TextoPadraoProdutoDetalhe>();
        }

        public int IdTextoPadrao { get; set; }
        public int IdTipoTexto { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public string NmTextoPadrao { get; set; }
        public string TxTextoPadrao { get; set; }
        public string TxAbreviacao { get; set; }
        public int? IdUsuario { get; set; }

        public virtual TipoDiversos IdTipoTextoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<TextoPadraoPrescricaoItemTipo> TextoPadraoPrescricaoItemTipo { get; set; }
        public virtual ICollection<TextoPadraoProdutoDetalhe> TextoPadraoProdutoDetalhe { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoProdutoTabelaOperadora
    {
        public ServicoProdutoTabelaOperadora()
        {
            ServicoServicoProdutoTabelaOperadora = new HashSet<ServicoServicoProdutoTabelaOperadora>();
        }

        public int IdServicoProdutoTabela { get; set; }
        public int IdOperadora { get; set; }
        public bool InReferencia { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtInicioVigencia { get; set; }
        public int? IdUsuario { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual ServicoProdutoTabela IdServicoProdutoTabelaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ServicoServicoProdutoTabelaOperadora> ServicoServicoProdutoTabelaOperadora { get; set; }
    }
}
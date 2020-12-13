﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoProdutoCategoria
    {
        public ServicoProdutoCategoria()
        {
            GeracaoAjusteServicoHistorico = new HashSet<GeracaoAjusteServicoHistorico>();
            Servico = new HashSet<Servico>();
            ServicoIncidenciaCategoria = new HashSet<ServicoIncidenciaCategoria>();
            ServicoProdutoCategoriaServicoProdutoCategoriaIdServicoCategoriaFilhoNavigation = new HashSet<ServicoProdutoCategoriaServicoProdutoCategoria>();
            ServicoProdutoCategoriaServicoProdutoCategoriaIdServicoCategoriaPaiNavigation = new HashSet<ServicoProdutoCategoriaServicoProdutoCategoria>();
        }

        public int IdServicoCategoria { get; set; }
        public int IdServicoProdutoTabelaTipo { get; set; }
        public string NmServicoCategoria { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public short NrOrdem { get; set; }

        public virtual TipoDiversos IdServicoProdutoTabelaTipoNavigation { get; set; }
        public virtual ICollection<GeracaoAjusteServicoHistorico> GeracaoAjusteServicoHistorico { get; set; }
        public virtual ICollection<Servico> Servico { get; set; }
        public virtual ICollection<ServicoIncidenciaCategoria> ServicoIncidenciaCategoria { get; set; }
        public virtual ICollection<ServicoProdutoCategoriaServicoProdutoCategoria> ServicoProdutoCategoriaServicoProdutoCategoriaIdServicoCategoriaFilhoNavigation { get; set; }
        public virtual ICollection<ServicoProdutoCategoriaServicoProdutoCategoria> ServicoProdutoCategoriaServicoProdutoCategoriaIdServicoCategoriaPaiNavigation { get; set; }
    }
}
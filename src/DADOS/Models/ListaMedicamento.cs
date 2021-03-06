﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ListaMedicamento
    {
        public int IdProduto { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public string NmProduto { get; set; }
        public string FormaFarmaceutica { get; set; }
        public string Aresentação { get; set; }
        public string Descrição { get; set; }
        public string ValorBase { get; set; }
        public string TxComplemento { get; set; }
        public string BaseKit { get; set; }
        public string Padronizado { get; set; }
        public string ConsumoMínimo { get; set; }
        public string UnidadeDeConsumo { get; set; }
        public string UnidadeDeCompra { get; set; }
        public int InConsignado { get; set; }
        public bool InAtivo { get; set; }
        public string NmClassificacao { get; set; }
        public string NmListaMedControlado { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdPessoa { get; set; }
        public string TxLogin { get; set; }
        public DateTime? DtAlteracao { get; set; }
        public bool InPadronizado { get; set; }
        public int InFabricante { get; set; }
        public string ViaAdministracao { get; set; }
    }
}
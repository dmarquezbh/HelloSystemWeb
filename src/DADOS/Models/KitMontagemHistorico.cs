﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class KitMontagemHistorico
    {
        public int IdKitMontagemHistorico { get; set; }
        public int IdKitMontagem { get; set; }
        public int IdKit { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public int IdUsuario { get; set; }
        public int? IdLoteProdutoItem { get; set; }
        public int? IdProdutoDetalhe { get; set; }
        public int? IdFabricante { get; set; }
        public DateTime? DtCadastro { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class KitTaxasGases
    {
        public KitTaxasGases()
        {
            KitTaxasGasesOperadora = new HashSet<KitTaxasGasesOperadora>();
            KitTaxasGasesUnidadeOrganizacional = new HashSet<KitTaxasGasesUnidadeOrganizacional>();
            ServicoKitTaxasGasesServico = new HashSet<ServicoKitTaxasGasesServico>();
            TaxaFolhaDeSala = new HashSet<TaxaFolhaDeSala>();
        }

        public int IdKit { get; set; }
        public string NmKit { get; set; }
        public bool InKitEditavel { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool InAtivo { get; set; }
        public string TxObservacao { get; set; }
        public int? IdProdutoDetalhe { get; set; }
        public int? IdTipoKit { get; set; }
        public int? IdOperadora { get; set; }

        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
        public virtual ICollection<KitTaxasGasesOperadora> KitTaxasGasesOperadora { get; set; }
        public virtual ICollection<KitTaxasGasesUnidadeOrganizacional> KitTaxasGasesUnidadeOrganizacional { get; set; }
        public virtual ICollection<ServicoKitTaxasGasesServico> ServicoKitTaxasGasesServico { get; set; }
        public virtual ICollection<TaxaFolhaDeSala> TaxaFolhaDeSala { get; set; }
    }
}
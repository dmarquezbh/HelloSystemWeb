﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Kit
    {
        public Kit()
        {
            KitComposicaoKitIdKitFilhoNavigation = new HashSet<KitComposicaoKit>();
            KitComposicaoKitIdKitPaiNavigation = new HashSet<KitComposicaoKit>();
            KitComposicaoProduto = new HashSet<KitComposicaoProduto>();
            KitProcedimentoServico = new HashSet<KitProcedimentoServico>();
            KitServico = new HashSet<KitServico>();
            KitUnidadeOrganizacional = new HashSet<KitUnidadeOrganizacional>();
            ProdutoDetalheViaAdministracao = new HashSet<ProdutoDetalheViaAdministracao>();
            RestricaoKit = new HashSet<RestricaoKit>();
        }

        public int IdKit { get; set; }
        public string NmKit { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool InAtivo { get; set; }
        public string TxObservacao { get; set; }
        public int? IdProdutoDetalhe { get; set; }
        public int? IdTipoKit { get; set; }

        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
        public virtual KitProduto KitProduto { get; set; }
        public virtual ICollection<KitComposicaoKit> KitComposicaoKitIdKitFilhoNavigation { get; set; }
        public virtual ICollection<KitComposicaoKit> KitComposicaoKitIdKitPaiNavigation { get; set; }
        public virtual ICollection<KitComposicaoProduto> KitComposicaoProduto { get; set; }
        public virtual ICollection<KitProcedimentoServico> KitProcedimentoServico { get; set; }
        public virtual ICollection<KitServico> KitServico { get; set; }
        public virtual ICollection<KitUnidadeOrganizacional> KitUnidadeOrganizacional { get; set; }
        public virtual ICollection<ProdutoDetalheViaAdministracao> ProdutoDetalheViaAdministracao { get; set; }
        public virtual ICollection<RestricaoKit> RestricaoKit { get; set; }
    }
}
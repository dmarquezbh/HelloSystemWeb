﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoTraducaoVigencia
    {
        public int IdServicoTraducao { get; set; }
        public int IdServicoReferencia { get; set; }
        public int IdServico { get; set; }
        public int? IdOperadora { get; set; }
        public int? IdPlano { get; set; }
        public int? IdServicoProdutoTabela { get; set; }
        public DateTime DtInicioVigencia { get; set; }
        public DateTime? DtFinalVigencia { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public DateTime DtCadastro { get; set; }
        public int? IdUsuarioDesativacao { get; set; }
        public DateTime? DtDesativacao { get; set; }
        public bool? InAtivo { get; set; }

        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual Plano IdPlanoNavigation { get; set; }
        public virtual Servico IdServicoNavigation { get; set; }
        public virtual ServicoProdutoTabela IdServicoProdutoTabelaNavigation { get; set; }
        public virtual Servico IdServicoReferenciaNavigation { get; set; }
        public virtual Usuario IdUsuarioCadastroNavigation { get; set; }
        public virtual Usuario IdUsuarioDesativacaoNavigation { get; set; }
    }
}
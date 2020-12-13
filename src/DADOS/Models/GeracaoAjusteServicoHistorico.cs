﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class GeracaoAjusteServicoHistorico
    {
        public int IdGeracaoAjusteServicoHistorico { get; set; }
        public int IdOperadora { get; set; }
        public int? IdPlano { get; set; }
        public int? IdServicoCategoria { get; set; }
        public double VlReajuste { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtVigencia { get; set; }
        public DateTime DtCadastro { get; set; }
        public int IdServicoGrupo { get; set; }

        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual Plano IdPlanoNavigation { get; set; }
        public virtual ServicoProdutoCategoria IdServicoCategoriaNavigation { get; set; }
        public virtual Servico IdServicoGrupoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
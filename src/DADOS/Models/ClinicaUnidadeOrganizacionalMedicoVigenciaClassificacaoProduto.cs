﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ClinicaUnidadeOrganizacionalMedicoVigenciaClassificacaoProduto
    {
        public int IdClinicaUnidadeorganizacionalMedicoVigenciaClassificacaoproduto { get; set; }
        public int IdClinicaUnidadeOrganizacionalMedicoVigencia { get; set; }
        public int IdClassificacao { get; set; }
        public double NrPercentual { get; set; }
        public bool? InAtivo { get; set; }
        public int IdUsuarioAtivacao { get; set; }
        public DateTime DtAtivacao { get; set; }
        public int? IdUsuarioInativacao { get; set; }
        public DateTime? DtInativacao { get; set; }

        public virtual ClassificacaoProduto IdClassificacaoNavigation { get; set; }
        public virtual ClinicaUnidadeOrganizacionalMedicoVigencia IdClinicaUnidadeOrganizacionalMedicoVigenciaNavigation { get; set; }
        public virtual Usuario IdUsuarioAtivacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioInativacaoNavigation { get; set; }
    }
}
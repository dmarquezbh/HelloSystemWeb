﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoClassificacaoHospitalSus
    {
        public int IdServicoclassificacaohospitalsus { get; set; }
        public int IdServicoClassificacao { get; set; }
        public short InTerceiro { get; set; }
        public int IdPessoa { get; set; }
        public bool? InAtivo { get; set; }
        public DateTime DtAtualizacao { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Pessoa IdPessoaNavigation { get; set; }
        public virtual TipoDiversos IdServicoclassificacaohospitalsusNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
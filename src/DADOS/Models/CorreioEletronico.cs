﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CorreioEletronico
    {
        public CorreioEletronico()
        {
            PessoaCorreioEletronico = new HashSet<PessoaCorreioEletronico>();
            UnidadeOrganizacionalCorreioEletronico = new HashSet<UnidadeOrganizacionalCorreioEletronico>();
        }

        public int IdCorreioEletronico { get; set; }
        public string TxEnderecoEletronico { get; set; }
        public int IdCorreioEletronicoTipo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual TipoDiversos IdCorreioEletronicoTipoNavigation { get; set; }
        public virtual ICollection<PessoaCorreioEletronico> PessoaCorreioEletronico { get; set; }
        public virtual ICollection<UnidadeOrganizacionalCorreioEletronico> UnidadeOrganizacionalCorreioEletronico { get; set; }
    }
}
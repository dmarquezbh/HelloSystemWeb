﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class EnderecoPessoaRelatorioBi
    {
        public int IdPessoa { get; set; }
        public int? IdEndereco { get; set; }
        public string Endereco { get; set; }
        public string EnderecoLatLong { get; set; }
        public string LogNo { get; set; }
        public string NrNumero { get; set; }
        public string TxComplemento { get; set; }
        public string CepCidade { get; set; }
        public string SgUf { get; set; }
        public string Bairro { get; set; }
        public int? IdBairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string CidadeBi { get; set; }
        public string NmPais { get; set; }
        public string CdIbge { get; set; }
        public int LocNu { get; set; }
        public int IdUf { get; set; }
        public string TipoLogradouro { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PessoaJuridica
    {
        public int IdPessoa { get; set; }
        public string NmPessoa { get; set; }
        public bool InAtivo { get; set; }
        public string CdCnpj { get; set; }
        public string CdInscricaoEstadual { get; set; }
        public string CdInscricaoMunicipal { get; set; }
        public string DtInicioAtividade { get; set; }
        public string IdEmpresaTipo { get; set; }
        public string TxRazaoSocial { get; set; }
    }
}
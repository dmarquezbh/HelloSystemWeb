﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class SptConsultaRemessa
    {
        public string NmPessoa { get; set; }
        public string NrCartaoIdentificacao { get; set; }
        public string NrMatricula { get; set; }
        public string Validacartão { get; set; }
        public string Validamatricula { get; set; }
        public int? IdLoteContaMapa { get; set; }
        public int IdLote { get; set; }
        public int IdAtendimento { get; set; }
        public int? NrCartaRemessa { get; set; }
    }
}
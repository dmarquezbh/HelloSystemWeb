﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CensoSinteticoIpmmi
    {
        public DateTime? Dia { get; set; }
        public int? LeitosDisponiveis { get; set; }
        public int IdContador { get; set; }
        public int? IdTipo { get; set; }
        public string NmTipo { get; set; }
        public string AbrvTipo { get; set; }
        public DateTime? DtAtendimento { get; set; }
        public int? IdAtendimento { get; set; }
        public string NmPessoa { get; set; }
        public string NrLeito { get; set; }
        public int? LeitoOrdem { get; set; }
        public string NmUnidadeOrganizacional { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public string NmOperadora { get; set; }
        public string Obs { get; set; }
        public string NmEspecialidade { get; set; }
        public DateTime? DtAlta { get; set; }
        public string NmTipoAlta { get; set; }
        public string DtNascimento { get; set; }
        public int? IdNumeroProntuario { get; set; }
        public string TipoLeito { get; set; }
    }
}
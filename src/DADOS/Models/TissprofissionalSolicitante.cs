﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TissprofissionalSolicitante
    {
        public int IdAtendimento { get; set; }
        public int IdGuia { get; set; }
        public int? IdPessoa { get; set; }
        public string NmMedico { get; set; }
        public string NrCrm { get; set; }
        public string UfCrm { get; set; }
        public int? IdEntidadeConselho { get; set; }
        public int? IdEspecialidade { get; set; }
        public string CdConvenio { get; set; }
        public string NmMedicoExec { get; set; }
        public string NrCrmExec { get; set; }
        public string UfCrmExec { get; set; }
        public string CdSolicitanteUnimed { get; set; }
        public string CdSolicitanteOperadora { get; set; }
        public int RvVersaoLinha { get; set; }
    }
}
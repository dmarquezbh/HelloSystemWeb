﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class SptExameEtapaLaboratorio
    {
        public int IdOrdemServico { get; set; }
        public int IdExame { get; set; }
        public int IdMaterialTipo { get; set; }
        public int IdFluxo { get; set; }
        public int IdEtapaTipo { get; set; }
        public int NrEtapa { get; set; }
        public short NrOrdem { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public int? IdPrestador { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public DateTime DtLimite { get; set; }
        public bool InAtraso { get; set; }
        public int? IdFuncResponsavel { get; set; }
        public bool InPendencia { get; set; }
    }
}
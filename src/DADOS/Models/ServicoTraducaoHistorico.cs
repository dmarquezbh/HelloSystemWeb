﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoTraducaoHistorico
    {
        public int IdServicoTraducaoHistorico { get; set; }
        public int IdServico { get; set; }
        public int IdServicoReferencia { get; set; }
        public DateTime DtInicioVigencia { get; set; }
        public int IdUsuarioInicioVigencia { get; set; }
        public DateTime? DtFinalVigencia { get; set; }
        public int? IdUsuarioFinalVigencia { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual Servico IdServicoNavigation { get; set; }
        public virtual Servico IdServicoReferenciaNavigation { get; set; }
    }
}
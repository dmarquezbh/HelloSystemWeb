﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoFilmeIncidenciaAdicional
    {
        public int IdCheckinEnfermagem { get; set; }
        public int IdServico { get; set; }
        public int IdServicoFilho { get; set; }
        public int? IdContaItemServico { get; set; }
        public int? IdFilme { get; set; }
        public int? QnIncidenciaAdicional { get; set; }
        public int IdServicoFilmeIncidenciaAdicional { get; set; }
        public int? IdServicoGuia { get; set; }

        public virtual ServicoCheckinEnfermagem Id { get; set; }
        public virtual ContaItemServico IdContaItemServicoNavigation { get; set; }
        public virtual Filme IdFilmeNavigation { get; set; }
        public virtual Servico IdServicoFilhoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrdemServicoServicoExecutado
    {
        public int IdServico { get; set; }
        public int IdOrdemServico { get; set; }
        public int? IdServicoExecutado { get; set; }

        public virtual OrdemServicoServico Id { get; set; }
        public virtual Servico IdServicoExecutadoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ContaItemServicoAtendimentoServico
    {
        public int IdContaItemServico { get; set; }
        public int IdAtendimento { get; set; }
        public int IdServico { get; set; }
        public DateTime DtUso { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual AtendimentoServico AtendimentoServico { get; set; }
        public virtual ContaItemServico IdContaItemServicoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RepasseServicoUnidadeRepasse
    {
        public int IdServico { get; set; }
        public int IdUnidadeRepasse { get; set; }
        public DateTime DtLancamento { get; set; }
        public bool InAtual { get; set; }
        public bool? InParticular { get; set; }
        public double? NrPercentual { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public bool InAtivo { get; set; }
        public DateTime? DtDesativacao { get; set; }
        public int IdUsuario { get; set; }
        public bool? InAutomatico { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public double? VlRepasseFixo { get; set; }

        public virtual ServicoUnidadeRepasse Id { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
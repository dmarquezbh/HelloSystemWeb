﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrdemServicoExameObservacao
    {
        public int IdOrdemServico { get; set; }
        public int IdMaterialTipo { get; set; }
        public int IdExame { get; set; }
        public int IdObservacaoTipo { get; set; }
        public string TxObservacao { get; set; }

        public virtual OrdemServicoExame Id { get; set; }
        public virtual TipoDiversos IdObservacaoTipoNavigation { get; set; }
    }
}
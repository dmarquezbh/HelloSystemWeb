﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PrescricaoPadrao
    {
        public int IdSolicitacao { get; set; }
        public string TxDescricao { get; set; }

        public virtual Solicitacao IdSolicitacaoNavigation { get; set; }
    }
}
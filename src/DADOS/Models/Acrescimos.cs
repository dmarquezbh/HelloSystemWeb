﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Acrescimos
    {
        public int IdConta { get; set; }
        public int IdFechamentoItem { get; set; }
        public double? VlAcrescimo { get; set; }
        public string TxObservacoes { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public int IdUsuario { get; set; }
        public bool? InRepassavel { get; set; }
        public DateTime? DtAcrescimo { get; set; }
        public bool? InAtivo { get; set; }
        public int? IdArquivoEletronico { get; set; }

        public virtual FechamentoItem Id { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
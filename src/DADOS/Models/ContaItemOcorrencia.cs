﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ContaItemOcorrencia
    {
        public int IdContaItemOcorrencia { get; set; }
        public int IdContaItem { get; set; }
        public DateTime DtRegistro { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public int IdJustificativaOcorrenciaCti { get; set; }
        public int IdUsuario { get; set; }
        public string NmColaboradorMedico { get; set; }
        public double QtOcorrencia { get; set; }
        public double VlTotal { get; set; }
        public string TxObs { get; set; }

        public virtual ContaItem IdContaItemNavigation { get; set; }
        public virtual JustificativaOcorrenciaCti IdJustificativaOcorrenciaCtiNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
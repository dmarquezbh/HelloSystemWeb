﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Tisslog
    {
        public int IdTissLog { get; set; }
        public int IdTipoLog { get; set; }
        public DateTime DtLog { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdOperadora { get; set; }
        public int IdUsuario { get; set; }
        public string TxRetornoTratado { get; set; }
        public string NrMatricula { get; set; }
        public string TxRequest { get; set; }
        public string TxResponse { get; set; }
        public string NmBeneficiario { get; set; }

        public virtual TipoDiversos IdTipoLogNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
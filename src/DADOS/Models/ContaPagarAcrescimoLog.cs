﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ContaPagarAcrescimoLog
    {
        public int IdContapagarAcrescimoLog { get; set; }
        public int IdContaPagar { get; set; }
        public int IdTipoAcrescimo { get; set; }
        public double VlAcrescimo { get; set; }
        public DateTime? DtCadastro { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioOperacao { get; set; }

        public virtual Usuario IdUsuarioOperacaoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ReservaLeito
    {
        public int IdLeito { get; set; }
        public int IdReserva { get; set; }
        public string TxObservacao { get; set; }
        public DateTime DtInicioReserva { get; set; }
        public DateTime DtFimReserva { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int IdJustPadraoReservaleito { get; set; }
        public string NmPaciente { get; set; }

        public virtual TipoDiversos IdJustPadraoReservaleitoNavigation { get; set; }
        public virtual Leito IdLeitoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoDiariaLeitoTipo
    {
        public int IdServico { get; set; }
        public int IdLeitoTipo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual TipoDiversos IdLeitoTipoNavigation { get; set; }
        public virtual Servico IdServicoNavigation { get; set; }
    }
}
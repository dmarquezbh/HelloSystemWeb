﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class IntegraSistemaLegado
    {
        public int IdHospitale { get; set; }
        public int IdSistemaLegado { get; set; }
        public int IdEntidadeTipo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public string IdSistemaLegadoString { get; set; }
        public DateTime? DtCriacao { get; set; }

        public virtual TipoDiversos IdEntidadeTipoNavigation { get; set; }
    }
}
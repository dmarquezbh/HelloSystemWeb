﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class EventoLeitoAssociacao
    {
        public int IdEventoLeitoPai { get; set; }
        public int IdEventoLeitoFilho { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual LeitoEventoLeito IdEventoLeitoFilhoNavigation { get; set; }
        public virtual LeitoEventoLeito IdEventoLeitoPaiNavigation { get; set; }
    }
}
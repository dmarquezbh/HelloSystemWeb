﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AgendaHdCorpoClinico
    {
        public int IdAgenda { get; set; }
        public int IdCorpoClinico { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual AgendaHd IdAgendaNavigation { get; set; }
        public virtual Pessoa IdCorpoClinicoNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class HorarioHemodinamica
    {
        public HorarioHemodinamica()
        {
            AgendaHd = new HashSet<AgendaHd>();
        }

        public int IdHorario { get; set; }
        public int IdTipoDiversos { get; set; }
        public DateTime HrHora { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual TipoDiversos IdTipoDiversosNavigation { get; set; }
        public virtual ICollection<AgendaHd> AgendaHd { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoAgendaEtapa
    {
        public ServicoAgendaEtapa()
        {
            ServicoAgenda = new HashSet<ServicoAgenda>();
        }

        public int IdServicoAgendaEtapa { get; set; }
        public string TxDescricao { get; set; }
        public bool InObrigatorio { get; set; }
        public int SqServicoAgendaEtapa { get; set; }
        public string TxControlador { get; set; }

        public virtual ICollection<ServicoAgenda> ServicoAgenda { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoRegiaoAplicacao
    {
        public ServicoRegiaoAplicacao()
        {
            ServicoGuia = new HashSet<ServicoGuia>();
        }

        public int IdRegiaoAplicacao { get; set; }
        public int IdServico { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool? InAtivado { get; set; }

        public virtual TipoDiversos IdRegiaoAplicacaoNavigation { get; set; }
        public virtual Servico IdServicoNavigation { get; set; }
        public virtual ICollection<ServicoGuia> ServicoGuia { get; set; }
    }
}
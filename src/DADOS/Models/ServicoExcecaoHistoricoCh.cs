﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoExcecaoHistoricoCh
    {
        public int IdServico { get; set; }
        public int IdOperadora { get; set; }
        public DateTime DtVigencia { get; set; }
        public double VlCh { get; set; }
        public double? VlChExterno { get; set; }
        public bool? InPrecoAtual { get; set; }
        public int IdUsuario { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual ServicoExcecao Id { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class UnidadeOrganizacionalUnidadeOrganizacionalOcorrenciaTipo
    {
        public int IdUnidadeOrganizacional { get; set; }
        public int IdOcorrencia { get; set; }
        public DateTime DtOcorrencia { get; set; }
        public string TxMotivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual TipoDiversos IdOcorrenciaNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
    }
}
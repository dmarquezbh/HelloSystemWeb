﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class UnidadeOrganizacionalTelefone
    {
        public UnidadeOrganizacionalTelefone()
        {
            UnidadeOrganizacionalTelefoneHorario = new HashSet<UnidadeOrganizacionalTelefoneHorario>();
        }

        public int IdUnidadeOrganizacional { get; set; }
        public int IdTelefone { get; set; }
        public int IdTelefoneTipo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public string NrRamal { get; set; }
        public string NmContato { get; set; }

        public virtual Telefone IdTelefoneNavigation { get; set; }
        public virtual TipoDiversos IdTelefoneTipoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual ICollection<UnidadeOrganizacionalTelefoneHorario> UnidadeOrganizacionalTelefoneHorario { get; set; }
    }
}
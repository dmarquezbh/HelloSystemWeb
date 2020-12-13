﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PessoaTelefone
    {
        public PessoaTelefone()
        {
            PessoaTelefoneHorario = new HashSet<PessoaTelefoneHorario>();
        }

        public int IdPessoaTelefone { get; set; }
        public int IdPessoa { get; set; }
        public int IdTelefone { get; set; }
        public int IdTelefoneTipo { get; set; }
        public string NrRamal { get; set; }
        public string NmContato { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual Pessoa IdPessoaNavigation { get; set; }
        public virtual Telefone IdTelefoneNavigation { get; set; }
        public virtual TipoDiversos IdTelefoneTipoNavigation { get; set; }
        public virtual ICollection<PessoaTelefoneHorario> PessoaTelefoneHorario { get; set; }
    }
}
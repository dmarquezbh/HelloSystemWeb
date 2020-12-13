﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class IntegracaoConnect
    {
        public IntegracaoConnect()
        {
            LaudoLaboratorioIntegracaoConnect = new HashSet<LaudoLaboratorioIntegracaoConnect>();
            LaudoSadtIntegracaoConnect = new HashSet<LaudoSadtIntegracaoConnect>();
        }

        public int IdIntegracao { get; set; }
        public int IdPessoa { get; set; }
        public int IdUsuario { get; set; }
        public bool InAtivo { get; set; }
        public int IdUsuarioExternoAutomatico { get; set; }
        public string TxLoginAutomatico { get; set; }
        public string TxSenhaAutomatica { get; set; }
        public int? IdUsuarioExterno { get; set; }

        public virtual Pessoa IdPessoaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<LaudoLaboratorioIntegracaoConnect> LaudoLaboratorioIntegracaoConnect { get; set; }
        public virtual ICollection<LaudoSadtIntegracaoConnect> LaudoSadtIntegracaoConnect { get; set; }
    }
}
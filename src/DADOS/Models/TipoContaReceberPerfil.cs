﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TipoContaReceberPerfil
    {
        public int IdTipocontareceberPerfil { get; set; }
        public int IdTipoConta { get; set; }
        public int IdPerfil { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool? InAtivo { get; set; }
        public int IdUsuario { get; set; }

        public virtual Perfil IdPerfilNavigation { get; set; }
        public virtual TipoDiversos IdTipoContaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
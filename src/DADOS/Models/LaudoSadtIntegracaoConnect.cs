﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LaudoSadtIntegracaoConnect
    {
        public int IdLaudoSadt { get; set; }
        public int IdIntegracao { get; set; }
        public Guid GuidIntegracao { get; set; }
        public int IdUsuario { get; set; }
        public bool InAtivo { get; set; }

        public virtual IntegracaoConnect IdIntegracaoNavigation { get; set; }
        public virtual LaudoSadt IdLaudoSadtNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PontoAtendimentoUsuario
    {
        public int IdPontoAtendimento { get; set; }
        public int IdUsuario { get; set; }

        public virtual PontoAtendimento IdPontoAtendimentoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}